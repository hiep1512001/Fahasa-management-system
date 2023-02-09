using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahasa_Management_System.Model;

namespace Fahasa_Management_System.GUI.Manager
{
    public partial class Frm_Book : Form
    {
        private int Masach = 0;
        private DataTable dtSach;
        public Frm_Book()
        {
            InitializeComponent();
        }

        private void txt_Buy_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_Sell_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Frm_Book_Load(object sender, EventArgs e)
        {
            FahasaContextDB cont = new FahasaContextDB();

            dtSach = new DataTable("dtsach");
            dtSach.Columns.Add("Mã sách", System.Type.GetType("System.Int32"));
            dtSach.Columns.Add("Tên sách", System.Type.GetType("System.String"));
            dtSach.Columns.Add("Thể loại", System.Type.GetType("System.String"));
            dtSach.Columns.Add("Nhà xuất bản", System.Type.GetType("System.String"));
            dtSach.Columns.Add("Giá mua", System.Type.GetType("System.Int32"));
            dtSach.Columns.Add("Giá bán", System.Type.GetType("System.Int32"));
            dtSach.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            ThemdgvBook();
            dgv_Book.DataSource = dtSach;
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            foreach(THELOAI a in listTheloai)
            {
                cbo_Book_Type.Items.Add(a.TENTL);
            }
            foreach(NXB a in listNxb)
            {
                cbo_Publishing.Items.Add(a.TENNXB);
            }
        }
        void ThemdgvBook()
        {
            dtSach.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            List<SACH> listsach = cont.SACHes.ToList();
            foreach (SACH a in listsach)
            {
                string Theloai = "";
                string Tennxb = "";
                foreach (THELOAI b in listTheloai)
                {
                    if (a.MATL == b.MATL)
                    {
                        Theloai = b.TENTL;
                    }
                }
                foreach (NXB b in listNxb)
                {
                    if (a.MANXB == b.MANXB)
                    {
                        Tennxb = b.TENNXB;
                    }
                }
                dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Theloai, Tennxb,a.GIAMUA, a.GIABAN, a.SOLUONG });
            }
        }
        void ThemBook()
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            string Kt = "";
            if (txt_Book_Title.Text == "")
            {
                Kt = Kt + "Chưa điền tên sản phẩm!\n";
            }
            if (cbo_Book_Type.Text == "Thể loại") 
            {
                Kt = Kt + "Chưa chọn thể loại!\n";
            }
            if (cbo_Publishing.Text == "Nhà XB")
            {
                Kt = Kt + "Chưa chọn nhà xuất bản!\n";
            }
            if (txt_Buy_Price.Text == "")
            {
                Kt = Kt + "Chưa điền giá mua!\n";
            }
            if (txt_Sell_Price.Text == "")
            {
                Kt = Kt + "Chưa điền giá bán!\n";
            }
            if (numUD_Quantity.Value == 0)
            {
                Kt = Kt + "Chưa điền số lượng!\n";
            }
            if (txt_Buy_Price.Text != "" && txt_Sell_Price.Text != "")
            {
                if (Convert.ToInt32(txt_Sell_Price.Text) <= Convert.ToInt32(txt_Buy_Price.Text))
                {
                    Kt = Kt + "Giá mua phải nhỏ hơn giá bán!";
                }
            }
            if (Kt == "")
            {
                SACH a = new SACH();
                a.TENSACH = txt_Book_Title.Text;
                a.GIAMUA = Convert.ToInt32(txt_Buy_Price.Text);
                a.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                a.SOLUONG = Convert.ToInt32(numUD_Quantity.Value);
                foreach (NXB b in listNxb)
                {
                    if (cbo_Publishing.Text == b.TENNXB)
                    {
                        a.MANXB = b.MANXB;
                    }
                }
                foreach (THELOAI b in listTheloai)
                {
                    if (cbo_Book_Type.Text == b.TENTL)
                    {
                        a.MATL = b.MATL;
                    }
                }
                List<SACH> ListSach = cont.SACHes.ToList();
                int t = 1;
                foreach(SACH b in ListSach)
                {
                    if(a.TENSACH == b.TENSACH)
                    {
                        DialogResult dlr = MessageBox.Show("Sách đã có trong kho!\nNhấn OK để tăng số lượng.\nNhấn Cancel để kết thúc.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if(dlr == DialogResult.OK)
                        {
                            b.SOLUONG = a.SOLUONG + b.SOLUONG;
                            var update = (from u in cont.SACHes where u.MASACH == b.MASACH select u).Single();
                            update.GIAMUA = a.GIAMUA;
                            update.GIABAN = a.GIABAN;
                            update.SOLUONG = b.SOLUONG;
                            cont.SaveChanges();
                            t = 0;
                            Resetvalue();
                            Resetlable();
                            break;
                        }
                        else
                        {
                            t = 0;
                            Resetvalue();
                            Resetlable();
                            break;
                        }
                    }
                }
                if (t == 1)
                {
                    using (var db = new FahasaContextDB())
                    {
                        db.SACHes.Add(a);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    Resetvalue();
                    Resetlable();
                }
            }
            else
            {
                Resetlable();
                GoiY();
            }
        }
        void Resetlable()
        {
            lblTensach.Text = "";
            lblTheloai.Text = "";
            lblNxb.Text = "";
            lblGiamua.Text = "";
            lblGiaban.Text = "";
            lblSoluong.Text = "";
        }
        private void btn_Add_New_Book_Click(object sender, EventArgs e)
        {
            ThemBook();
            ThemdgvBook();
        }

        private void dgv_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Masach = Convert.ToInt32(dgv_Book.Rows[e.RowIndex].Cells["Mã sách"].FormattedValue.ToString());
                txt_Book_Title.Text = dgv_Book.Rows[e.RowIndex].Cells["Tên sách"].FormattedValue.ToString();
                txt_Sell_Price.Text = dgv_Book.Rows[e.RowIndex].Cells["Giá bán"].FormattedValue.ToString();
                txt_Buy_Price.Text = dgv_Book.Rows[e.RowIndex].Cells["Giá mua"].FormattedValue.ToString();
                numUD_Quantity.Value = Convert.ToInt32(dgv_Book.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                cbo_Book_Type.Text= dgv_Book.Rows[e.RowIndex].Cells["Thể loại"].FormattedValue.ToString();
                cbo_Publishing.Text = dgv_Book.Rows[e.RowIndex].Cells["Nhà xuất bản"].FormattedValue.ToString();
                btn_Add_New_Book.Enabled = false;
            }
        }
        void Sua()
        {
            string Kt = "";
            if (Masach!=0)
            {
                if (txt_Book_Title.Text == "")
                {
                    Kt = Kt + "Chưa điền tên sản phẩm!\n";
                }
                if (cbo_Book_Type.Text == "Thể loại")
                {
                    Kt = Kt + "Chưa chọn thể loại!\n";
                }
                if (cbo_Publishing.Text == "Nhà XB")
                {
                    Kt = Kt + "Chưa chọn nhà xuất bản!\n";
                }
                if (txt_Buy_Price.Text == "")
                {
                    Kt = Kt + "Chưa điền giá mua!\n";
                }
                if (txt_Sell_Price.Text == "")
                {
                    Kt = Kt + "Chưa điền giá bán!\n";
                }
                if (numUD_Quantity.Value == 0)
                {
                    Kt = Kt + "Chưa điền số lượng!\n";
                }
                if (txt_Buy_Price.Text != "" && txt_Sell_Price.Text != "")
                {
                    if (Convert.ToInt32(txt_Sell_Price.Text) <= Convert.ToInt32(txt_Buy_Price.Text))
                    {
                        Kt = Kt + "Giá mua phải nhỏ hơn giá bán!";
                    }
                }
                if (Kt == "")
                {
                    int Manxb = 0;
                    int Matl = 0;
                    FahasaContextDB cont = new FahasaContextDB();
                    List<THELOAI> listTheloai = cont.THELOAIs.ToList();
                    List<NXB> listNxb = cont.NXBs.ToList();
                    foreach (NXB b in listNxb)
                    {
                        if (cbo_Publishing.Text == b.TENNXB)
                        {
                            Manxb = b.MANXB;
                        }
                    }
                    foreach (THELOAI b in listTheloai)
                    {
                        if (cbo_Book_Type.Text == b.TENTL)
                        {
                            Matl = b.MATL;
                        }
                    }
                    List<SACH> ListSach = cont.SACHes.ToList();
                    var update = (from u in cont.SACHes where u.MASACH == Masach select u).Single();
                    update.TENSACH = txt_Book_Title.Text;
                    update.MANXB = Manxb;
                    update.MATL = Matl;
                    update.GIAMUA = Convert.ToInt32(txt_Buy_Price.Text);
                    update.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                    update.SOLUONG = Convert.ToInt32(numUD_Quantity.Value);
                    cont.SaveChanges();
                    Manxb = 0;
                    Matl = 0;
                    MessageBox.Show("Sửa thành công!");
                    Resetlable();
                }
                else
                {
                    Resetlable();
                    GoiY();
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng vần sửa!");
            }
        }
        private void btn_Update_Book_Click(object sender, EventArgs e)
        {
            Sua();
            btn_Add_New_Book.Enabled = true;
            ThemdgvBook();
        }
        void GoiY()
        {
            if (txt_Book_Title.Text == "")
            {
                lblTensach.Text = "Chưa điền tên sách!";
            }
            if (cbo_Book_Type.Text == "Thể loại")
            {
                lblTheloai.Text = "Chưa chọn thể loại!";
            }
            if (cbo_Publishing.Text == "Nhà XB")
            {
                lblNxb.Text = "Chưa chọn nhà xuất bản!";
            }
            if (txt_Buy_Price.Text == "")
            {
                lblGiamua.Text = "Chưa điền giá mua!";
            }
            if (txt_Sell_Price.Text == "")
            {
                lblGiaban.Text = "Chưa điền giá bán!";
            }
            if (numUD_Quantity.Value == 0)
            {
                lblSoluong.Text = "Chưa điền số lượng!";
            }
            if (txt_Buy_Price.Text != "" && txt_Sell_Price.Text != "")
            {
                if (Convert.ToInt32(txt_Sell_Price.Text) <= Convert.ToInt32(txt_Buy_Price.Text))
                {
                    lblGiamua.Text = "Giá mua phải nhỏ hơn giá bán!";
                    lblGiaban.Text = "Giá mua phải nhỏ hơn giá bán!";
                }
            }
        }
        void Resetvalue()
        {
            txt_Buy_Price.Text = txt_Book_Title.Text = txt_Sell_Price.Text = "";
            numUD_Quantity.Value = 0;
            cbo_Book_Type.Text = "Thể loại";
            cbo_Publishing.Text = "Nhà XB";

        }
        private void btnDatlai_Click(object sender, EventArgs e)
        {
            Resetvalue();
            Resetlable();
            Masach = 0;
            btn_Add_New_Book.Enabled = true;
        }
        int Ktxoa(int Masach)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<CHITIETHOADONSACH> listChitietHoadonsach = cont.CHITIETHOADONSACHes.ToList();
            foreach (CHITIETHOADONSACH a in listChitietHoadonsach)
            {
                if (Masach == a.MASACH)
                {
                    t = 0;
                }
            }
            return t;
        }
        void Xoa()
        {
            FahasaContextDB cont = new FahasaContextDB();
            if (Masach != 0)
            {
                if (Ktxoa(Masach) == 1)
                {
                    var delete = (from a in cont.SACHes where (a.MASACH == Masach) select a).Single();
                    cont.SACHes.Remove(delete);
                    cont.SaveChanges();
                    Masach = 0; MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin sách, vì  sách đã được lưu vào dữ liệu chi tiết hóa đơn sách!\nĐể xóa sách phải thực hiện xóa dữ liệu trong chi tiết hóa đơn sách trước!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btn_Delete_Book_Click(object sender, EventArgs e)
        {
            Xoa();
            ThemdgvBook();
            Resetvalue();
            btn_Add_New_Book.Enabled = true;
        }

        private void btnThemnxb_Click(object sender, EventArgs e)
        {
            new FrmNxbTl().Show();
        }
    }
}
