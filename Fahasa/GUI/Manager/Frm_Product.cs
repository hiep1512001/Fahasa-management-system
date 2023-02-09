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
    public partial class Frm_Product : Form
    {
        private int MaSp = 0;
        private DataTable dtProduct;
        public Frm_Product()
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

        private void Frm_Product_Load(object sender, EventArgs e)
        {
            FahasaContextDB cont = new FahasaContextDB();
            dtProduct = new DataTable("dtproduct");
            dtProduct.Columns.Add("Mã sản phẩm", System.Type.GetType("System.Int32"));
            dtProduct.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dtProduct.Columns.Add("Loại sản phẩm", System.Type.GetType("System.String"));
            dtProduct.Columns.Add("Giá mua", System.Type.GetType("System.Int32"));
            dtProduct.Columns.Add("Giá bán", System.Type.GetType("System.Int32"));
            dtProduct.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            ThemdgvProduct();
            dgv_Product.DataSource = dtProduct;
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach(NHOMSP a in listNhomsp)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
        }
        void ThemdgvProduct()
        {
            dtProduct.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                string Loaisp = "";
                foreach (NHOMSP b in listNhomsp)
                {
                    if (a.MANHOM == b.MANHOM)
                    {
                        Loaisp = b.TENNHOM;
                    }
                }
                dtProduct.Rows.Add(new object[] { a.MASP, a.TENSP, Loaisp, a.GIAMUA, a.GIABAN, a.SOLUONG });
            }
        }
        void ThemProduct()
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            string Kt = "";
            if (txt_Product_Name.Text == "")
            {
                Kt = Kt + "Chưa điền tên sản phẩm!\n";
            }
            if (txt_Buy_Price.Text == "")
            {
                Kt = Kt + "Chưa điền giá mua!\n";
            }
            if (txt_Sell_Price.Text == "")
            {
                Kt = Kt + "Chưa điền giá bán!\n";
            }
            if (cbo_Product_Type.Text == "Loại Sản phẩm:")
            {
                Kt = Kt + "Chưa chọn loại sản phẩm!\n";
            }
            if (numUD_Quantity.Value == 0)
            {
                Kt = Kt + "Chưa điền số lượng!\n";
            }
            if(txt_Buy_Price.Text != ""&& txt_Sell_Price.Text != "")
            {
                if (Convert.ToInt32(txt_Sell_Price.Text) <= Convert.ToInt32(txt_Buy_Price.Text))
                {
                    Kt = Kt + "Giá mua phải nhỏ hơn giá bán!";
                }
            }
            if (Kt == "")
            {
                SANPHAM a = new SANPHAM();
                a.TENSP = txt_Product_Name.Text;
                a.GIAMUA =Convert.ToInt32( txt_Buy_Price.Text);
                a.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                a.SOLUONG =Convert.ToInt32( numUD_Quantity.Value);
                foreach (NHOMSP b in listNhomsp)
                {
                    if (cbo_Product_Type.Text == b.TENNHOM)
                    {
                        a.MANHOM = b.MANHOM;
                    }
                }
                int t = 1;
                List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                foreach(SANPHAM b in listSp)
                {
                    if(a.TENSP==b.TENSP)
                    {
                        DialogResult dlr = MessageBox.Show("Sản phẩm đã có trong kho!\nNhấn OK để tăng số lượng.\nNhấn Hủy bỏ để kết thúc.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dlr == DialogResult.OK)
                        {
                            b.SOLUONG = a.SOLUONG + b.SOLUONG;
                            var update = (from u in cont.SANPHAMs where u.MASP == b.MASP select u).Single();
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
                        db.SANPHAMs.Add(a);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Thêm thành công!");
                    Resetlable();
                    Resetvalue();
                }
            }
            else
            {
                Resetlable();
                GoiY();
            }
        }
        private void btn_Add_New_Product_Click(object sender, EventArgs e)
        {
            ThemProduct();
            ThemdgvProduct();
        }

        private void bntDatlai_Click(object sender, EventArgs e)
        {
            Resetvalue();
            Resetlable();
            MaSp = 0;
            btn_Add_New_Product.Enabled = true;
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MaSp = Convert.ToInt32(dgv_Product.Rows[e.RowIndex].Cells["Mã sản phẩm"].FormattedValue.ToString());
                txt_Product_Name.Text = dgv_Product.Rows[e.RowIndex].Cells["Tên sản phẩm"].FormattedValue.ToString();
                cbo_Product_Type.Text = dgv_Product.Rows[e.RowIndex].Cells["Loại sản phẩm"].FormattedValue.ToString();
                txt_Sell_Price.Text = dgv_Product.Rows[e.RowIndex].Cells["Giá bán"].FormattedValue.ToString();
                txt_Buy_Price.Text = dgv_Product.Rows[e.RowIndex].Cells["Giá mua"].FormattedValue.ToString();
                numUD_Quantity.Value = Convert.ToInt32(dgv_Product.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                btn_Add_New_Product.Enabled = false;
            }
        }
        void Sua()
        {
            string Kt = "";
            if (MaSp == 0)
            {
                Kt = Kt + "Chưa chọn dòng cần sửa!\n";
            }
            if (Kt == "")
            {
                if (txt_Product_Name.Text == "")
                {
                    Kt = Kt + "Chưa điền tên sản phẩm!\n";
                }
                if (txt_Buy_Price.Text == "")
                {
                    Kt = Kt + "Chưa điền giá mua!\n";
                }
                if (txt_Sell_Price.Text == "")
                {
                    Kt = Kt + "Chưa điền giá bán!\n";
                }
                if (cbo_Product_Type.Text == "Loại Sản phẩm:")
                {
                    Kt = Kt + "Chưa chọn loại sản phẩm!\n";
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
                    int Manhom = 0;
                    FahasaContextDB conn = new FahasaContextDB();
                    List<NHOMSP> listNhomsp = conn.NHOMSPs.ToList();
                    foreach (NHOMSP b in listNhomsp)
                    {
                        if (cbo_Product_Type.Text == b.TENNHOM)
                        {
                            Manhom = b.MANHOM;
                        }
                    }
                    var update = (from u in conn.SANPHAMs where u.MASP == MaSp select u).Single();
                    update.TENSP = txt_Product_Name.Text;
                    update.MANHOM = Manhom;
                    update.GIAMUA = Convert.ToInt32(txt_Buy_Price.Text);
                    update.GIABAN = Convert.ToInt32(txt_Sell_Price.Text);
                    update.SOLUONG = Convert.ToInt32(numUD_Quantity.Value);
                    conn.SaveChanges();
                    Manhom = 0;
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
                MessageBox.Show(Kt);
            }
        }
        private void btn_Update_Product_Click(object sender, EventArgs e)
        {
            Sua();
            btn_Add_New_Product.Enabled = true;
            ThemdgvProduct();
        }
        int Ktxoa(int masp)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<CHITIETHOADONSP> listChitietHoadonsp = cont.CHITIETHOADONSPs.ToList();
            foreach (CHITIETHOADONSP a in listChitietHoadonsp)
            {
                if (masp == a.MASP)
                {
                    t = 0;
                }
            }
            return t;
        }
        void Xoa()
        {
            FahasaContextDB cont = new FahasaContextDB();
            if (MaSp != 0)
            {
                if (Ktxoa(MaSp) == 1)
                {
                    var delete = (from a in cont.SANPHAMs where (a.MASP == MaSp) select a).Single();
                    cont.SANPHAMs.Remove(delete);
                    cont.SaveChanges();
                    MaSp = 0;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin sản phẩm, vì sản phẩm đã được lưu vào dữ liệu chi tiết hóa đơn sản phẩm!\nĐể xóa sản phẩm phải thực hiện xóa dữ liệu trong chi tiết hóa đơn sản phẩm trước!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btn_Delete_Product_Click(object sender, EventArgs e)
        {
            Xoa();
            ThemdgvProduct();
            txt_Buy_Price.Text = txt_Product_Name.Text = txt_Sell_Price.Text = "";
            numUD_Quantity.Value = 0;
            cbo_Product_Type.Text = "Loại Sản phẩm:";
            btn_Add_New_Product.Enabled = true;
        }
        void Resetlable()
        {
            lblTensp.Text = "";
            lblLoaisp.Text = "";
            lblGiamua.Text = "";
            lblGiaban.Text = "";
            lblSoluong.Text = "";
        }
        void GoiY()
        {
            if (txt_Product_Name.Text == "")
            {
                lblTensp.Text = "Chưa điền tên sản phẩm!";
            }
            if (cbo_Product_Type.Text == "Loại Sản phẩm:")
            {
                lblLoaisp.Text = "Chưa chọn loai sản phẩm!";
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
            txt_Buy_Price.Text = txt_Product_Name.Text = txt_Sell_Price.Text = "";
            numUD_Quantity.Value = 0;
            cbo_Product_Type.Text = "Loại Sản phẩm:";
        }
    }
}
