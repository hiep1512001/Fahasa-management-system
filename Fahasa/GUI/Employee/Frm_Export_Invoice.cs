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
using Fahasa_Management_System;

namespace Fahasa_Management_System.GUI.Employee
{
    public partial class Frm_Export_Invoice : Form
    {
        static public List<Hoadon> listHoadonxuat;
        private string Ten="+";
        private DataTable dtInvoice;
        public Frm_Export_Invoice()
        {
            InitializeComponent();
        }

        private void Frm_Export_Invoice_Load(object sender, EventArgs e)
        {
            dtInvoice = new DataTable("dtinvoice");
            dtInvoice.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            dtInvoice.Columns.Add("Tên sách", System.Type.GetType("System.String"));
            dtInvoice.Columns.Add("Tên sản phẩm", System.Type.GetType("System.String"));
            dtInvoice.Columns.Add("Giá bán", System.Type.GetType("System.Int32"));
            dtInvoice.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dtInvoice.Columns.Add("Thành tiền", System.Type.GetType("System.Int32"));
            dgv_Invoice.DataSource = dtInvoice;
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach(THELOAI a in listTheloai)
            {
                cbo_Book_Type.Items.Add(a.TENTL);
            }
            foreach(NHOMSP a in listNhomsp)
            {
                cbo_Product_Type.Items.Add(a.TENNHOM);
            }
            List<SACH> listSach = cont.SACHes.ToList();
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            foreach(SACH a in listSach)
            {
                cbo_Book_Name.Items.Add(a.TENSACH);
            }
            foreach(SANPHAM a in listSp)
            {
                cbo_Product_Name.Items.Add(a.TENSP);
            }
            dtp_Invoice_Date.Value = DateTime.Now;
            dtp_Invoice_Date.MaxDate = DateTime.Now;
        }
        string  KtraThem()
        {
            string  t = "";
            for (int i = 0; i < dgv_Invoice.RowCount; i++)
            {
                if (cbo_Book_Name.Text == dgv_Invoice.Rows[i].Cells[1].Value.ToString())
                {
                    t = t+"Sách đã được thêm vào hóa đơn!\n";
                    break;
                }
                if (cbo_Product_Name.Text == dgv_Invoice.Rows[i].Cells[2].Value.ToString())
                {
                    t = t+"Sản phẩm đã được thêm vào hóa đơn!";
                    break;
                }
            }
            return t;
        }
        void Themdonhang()
        {
            string t = KtraThem();
            if (t == "")
            {
                string kt = "";
                if (cbo_Book_Name.Text != "Tên sách")
                {
                    if (numUD_sach.Value != 0)
                    {
                        int Giaban = 0;
                        FahasaContextDB cont = new FahasaContextDB();
                        List<SACH> listSach = cont.SACHes.ToList();
                        foreach (SACH a in listSach)
                        {
                            if (a.TENSACH == cbo_Book_Name.Text)
                            {
                                Giaban = Convert.ToInt32(a.GIABAN);
                                break;
                            }
                        }
                        int thanhtien = Giaban * Convert.ToInt32(numUD_sach.Value);
                        dtInvoice.Rows.Add(new object[] { dtp_Invoice_Date.Value.ToShortDateString(), cbo_Book_Name.Text, "", Giaban, numUD_sach.Value, thanhtien });
                    }
                    else
                    {
                        kt = kt + "Chưa nhập số lượng sách mua!\n";
                    }
                }
                if (cbo_Product_Name.Text != "Tên SP")
                {
                    if (numUD_Quantity.Value != 0)
                    {
                        int Giaban = 0;
                        FahasaContextDB cont = new FahasaContextDB();
                        List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                        foreach (SANPHAM a in listSp)
                        {
                            if (a.TENSP == cbo_Product_Name.Text)
                            {
                                Giaban = Convert.ToInt32(a.GIABAN);
                                break;
                            }
                        }
                        int thanhtien = Giaban * Convert.ToInt32(numUD_Quantity.Value);
                        dtInvoice.Rows.Add(new object[] { dtp_Invoice_Date.Value.ToShortDateString(), "", cbo_Product_Name.Text, Giaban, numUD_Quantity.Value, thanhtien });
                    }
                    else
                    {
                        kt = kt + "Chưa nhập số lượng sản phẩm mua!";
                    }
                }
                if (kt != "")
                {
                    MessageBox.Show(kt);
                }

            }
            else
            {
                MessageBox.Show(t);
            }
            cbo_Product_Name.Text = "Tên SP";
            cbo_Book_Name.Text = "Tên sách";
            numUD_Quantity.Value = 0;
            numUD_sach.Value = 0;
            Ten = "+";
        }
        private void btn_Add_Invoice_Click(object sender, EventArgs e)
        {
            if(cbo_Book_Name.Text== "Tên sách" & cbo_Product_Name.Text == "Tên SP")
            {
                MessageBox.Show("Chưa chọn sản phẩm hoặc sách cần thêm!");
            }
            else
            {
                Themdonhang();
                txt_Total_Amount.Text = "Tổng: " + Tongtien().ToString() + "VND";
            }
        }

        private void cbo_Book_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Book_Name.Items.Clear();
            string Tentl = cbo_Book_Type.Text;
            int Maloai = 0;
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            foreach(THELOAI a in listTheloai)
            {
                if (a.TENTL == Tentl)
                {
                    Maloai = a.MATL;
                    break;
                }
            }
            foreach (SACH b in listSach)
            {
                if (Maloai == b.MATL &&  b.SOLUONG!=0)
                {
                    cbo_Book_Name.Items.Add(b.TENSACH);
                }
            }
        }

        private void cbo_Book_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tensach = cbo_Book_Name.Text;
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            foreach(SACH a in listSach)
            {
                if (a.TENSACH == Tensach)
                {
                    numUD_sach.Maximum = a.SOLUONG;
                }
            }
        }

        private void cbo_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Product_Name.Items.Clear();
            string Tentl = cbo_Product_Type.Text;
            int Maloai = 0;
            FahasaContextDB cont = new FahasaContextDB();
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            List<NHOMSP> listTheloai = cont.NHOMSPs.ToList();
            foreach (NHOMSP a in listTheloai)
            {
                if (a.TENNHOM == Tentl)
                {
                    Maloai = a.MANHOM;
                    break;
                }
            }
            foreach (SANPHAM b in listSp)
            {
                if (Maloai == b.MANHOM && b.SOLUONG !=0 )
                {
                    cbo_Product_Name.Items.Add(b.TENSP);
                }
            }
        }

        private void cbo_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tensap = cbo_Product_Name.Text;
            FahasaContextDB cont = new FahasaContextDB();
            List<SANPHAM> listSp = cont.SANPHAMs.ToList();
            foreach (SANPHAM a in listSp)
            {
                if (a.TENSP==Tensap)
                {
                    numUD_Quantity.Maximum =Convert.ToInt32( a.SOLUONG);
                }
            }
        }

        private void dgv_Invoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dtp_Invoice_Date.Value =Convert.ToDateTime( dgv_Invoice.Rows[e.RowIndex].Cells["Ngày lập hóa đơn"].FormattedValue.ToString());
                if(dgv_Invoice.Rows[e.RowIndex].Cells["Tên sách"].FormattedValue.ToString() != "")
                {
                    cbo_Book_Name.Text = dgv_Invoice.Rows[e.RowIndex].Cells["Tên sách"].FormattedValue.ToString();
                    numUD_sach.Value=Convert.ToInt32( dgv_Invoice.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                    cbo_Product_Name.Text = "";
                    numUD_Quantity.Value = 0;
                    Ten = cbo_Book_Name.Text;
                }
                if(dgv_Invoice.Rows[e.RowIndex].Cells["Tên sản phẩm"].FormattedValue.ToString() != "")
                {
                    cbo_Product_Name.Text = dgv_Invoice.Rows[e.RowIndex].Cells["Tên sản phẩm"].FormattedValue.ToString();
                    numUD_Quantity.Value= Convert.ToInt32(dgv_Invoice.Rows[e.RowIndex].Cells["Số lượng"].FormattedValue.ToString());
                    cbo_Book_Name.Text = "";
                    numUD_sach.Value = 0;
                    Ten=cbo_Product_Name.Text;
                }
                btn_Add_Invoice.Enabled = false;
            }
        }
        void Sua()
        {
            if (Ten != "")
            {
                for (int i = 0; i < dgv_Invoice.RowCount; i++)
                {
                    if (dgv_Invoice.Rows[i].Cells[1].Value.ToString() == Ten)
                    {
                        dgv_Invoice.Rows[i].Cells[0].Value = dtp_Invoice_Date.Value;
                        dgv_Invoice.Rows[i].Cells[1].Value = cbo_Book_Name.Text;
                        int Giaban = 0;
                        FahasaContextDB cont = new FahasaContextDB();
                        List<SACH> listSach = cont.SACHes.ToList();
                        foreach (SACH a in listSach)
                        {
                            if (a.TENSACH == cbo_Book_Name.Text)
                            {
                                Giaban = Convert.ToInt32(a.GIABAN);
                                break;
                            }
                        }
                        int thanhtien = Giaban * Convert.ToInt32(numUD_sach.Value);
                        dgv_Invoice.Rows[i].Cells[3].Value = Giaban;
                        dgv_Invoice.Rows[i].Cells[4].Value = numUD_sach.Value;
                        dgv_Invoice.Rows[i].Cells[5].Value = thanhtien;
                        break;
                    }
                    if(dgv_Invoice.Rows[i].Cells[2].Value.ToString() == Ten)
                    {
                        dgv_Invoice.Rows[i].Cells[0].Value = dtp_Invoice_Date.Value;
                        dgv_Invoice.Rows[i].Cells[2].Value = cbo_Product_Name.Text;
                        int Giaban = 0;
                        FahasaContextDB cont = new FahasaContextDB();
                        List<SANPHAM> listSp = cont.SANPHAMs.ToList();
                        foreach (SANPHAM a in listSp)
                        {
                            if (a.TENSP == cbo_Product_Name.Text)
                            {
                                Giaban = Convert.ToInt32(a.GIABAN);
                                break;
                            }
                        }
                        int thanhtien = Giaban * Convert.ToInt32(numUD_Quantity.Value);
                        dgv_Invoice.Rows[i].Cells[3].Value = Giaban;
                        dgv_Invoice.Rows[i].Cells[4].Value = numUD_Quantity.Value;
                        dgv_Invoice.Rows[i].Cells[5].Value = thanhtien;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần sửa");
            }
        }
        private void btn_Update_Invoice_Click(object sender, EventArgs e)
        {
            if (cbo_Book_Name.Text == "Tên sách" & cbo_Product_Name.Text == "Tên SP")
            {
                MessageBox.Show("Chưa chọn dòng cần sửa!");
            }
            else
            {
                Sua();
                cbo_Product_Name.Text = "Tên SP";
                cbo_Book_Name.Text = "Tên sách";
                numUD_Quantity.Value = 0;
                numUD_sach.Value = 0;
                Ten = "+";
                txt_Total_Amount.Text = "Tổng: " + Tongtien().ToString() + "VND";
                btn_Add_Invoice.Enabled = true;
            }
 
        }
        void Xoa()
        {
            if (Ten != "")
            {
                for (int i = 0; i < dgv_Invoice.RowCount; i++)
                {
                    if (dgv_Invoice.Rows[i].Cells[1].Value.ToString() == Ten)
                    {
                        dgv_Invoice.Rows.Remove(dgv_Invoice.Rows[i]); break;
                    }
                    if (dgv_Invoice.Rows[i].Cells[2].Value.ToString() == Ten)
                    {
                        dgv_Invoice.Rows.Remove(dgv_Invoice.Rows[i]); break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btn_Delete_Invoice_Click(object sender, EventArgs e)
        {
            if (cbo_Book_Name.Text == "Tên sách" & cbo_Product_Name.Text == "Tên SP")
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
            else{
                Xoa();
                cbo_Product_Name.Text = "Tên SP";
                cbo_Book_Name.Text = "Tên sách";
                numUD_Quantity.Value = 0;
                numUD_sach.Value = 0;
                Ten = "+";
                txt_Total_Amount.Text = "Tổng: " + Tongtien().ToString() + "VND";
                btn_Add_Invoice.Enabled = true;
            }

        }
        string Ktluu()
        {
            string kt = dgv_Invoice.Rows[0].Cells[0].Value.ToString();
            for (int i = 1; i < dgv_Invoice.RowCount; i++)
            {
                if (kt != dgv_Invoice.Rows[i].Cells[0].Value.ToString())
                kt = "";
                break;
            }
            return kt;
        }
        void Luu()
        {
            if (Ktluu() != "")
            {
                listHoadonxuat = new List<Hoadon>();
                HOADON a = new HOADON();
                a.NGAYLAPHOADON = Convert.ToDateTime(Ktluu());
                using (var db = new FahasaContextDB())
                {
                    db.HOADONs.Add(a);
                    db.SaveChanges();
                }
                FahasaContextDB cont = new FahasaContextDB();
                List<HOADON> listHoadon = cont.HOADONs.ToList();
                List<CHITIETHOADONSACH> listCTsach = cont.CHITIETHOADONSACHes.ToList();
                List<CHITIETHOADONSP> listCTsp = cont.CHITIETHOADONSPs.ToList();
                int Mahd = 0;
                foreach (HOADON b in listHoadon)
                {
                    int x = 0;
                    if (Ktluu() == b.NGAYLAPHOADON.ToString())
                    {
                        x = b.SOHD;
                    }
                    foreach (CHITIETHOADONSACH c in listCTsach)
                    {
                        if (b.SOHD == c.SOHD)
                        {
                            x = 0;
                        }
                    }
                    foreach(CHITIETHOADONSP c in listCTsp)
                    {
                        if (b.SOHD == c.SOHD)
                        {
                            x = 0;
                        }
                    }
                    if (x != 0)
                    {
                        Mahd = x;
                    }
                }
                if (Mahd != 0)
                {
                    Hoadon hoadon ;
                    for (int i=0; i < dgv_Invoice.RowCount; i++)
                    {
                        if(dgv_Invoice.Rows[i].Cells[1].Value.ToString() != "")
                        {
                            CHITIETHOADONSACH hds = new CHITIETHOADONSACH();
                            hds.SOHD = Mahd;
                            List<SACH> listSach = cont.SACHes.ToList();
                            foreach(SACH b in listSach)
                            {
                                if(b.TENSACH== dgv_Invoice.Rows[i].Cells[1].Value.ToString())
                                {
                                    hds.MASACH = b.MASACH;
                                    b.SOLUONG = b.SOLUONG - Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                                    var update = (from u in cont.SACHes where u.MASACH == b.MASACH select u).Single();
                                    update.SOLUONG = b.SOLUONG;
                                    cont.SaveChanges();
                                    break;
                                }
                            }
                            hds.SOLUONG = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                            using (var db = new FahasaContextDB())
                            {
                                db.CHITIETHOADONSACHes.Add(hds);
                                db.SaveChanges();
                            }
                            hoadon = new Hoadon();
                            hoadon.Mahd = Mahd;
                            hoadon.Ngaylap =(Convert.ToDateTime(dgv_Invoice.Rows[i].Cells[0].Value.ToString())).ToShortDateString();
                            hoadon.Ma = hds.MASACH;
                            hoadon.Tensach = dgv_Invoice.Rows[i].Cells[1].Value.ToString();
                            hoadon.Giaban = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[3].Value);
                            hoadon.Soluong =Convert.ToInt32( hds.SOLUONG);
                            hoadon.Thanhtien = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[5].Value);
                            hoadon.Tensp = "";
                            listHoadonxuat.Add(hoadon);
                        }
                        if(dgv_Invoice.Rows[i].Cells[2].Value.ToString() != "")
                        {
                            CHITIETHOADONSP ctsp = new CHITIETHOADONSP();
                            ctsp.SOHD = Mahd;
                            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
                            foreach(SANPHAM b in listSanpham)
                            {
                                if(b.TENSP== dgv_Invoice.Rows[i].Cells[2].Value.ToString())
                                {
                                    ctsp.MASP = b.MASP;
                                    b.SOLUONG = b.SOLUONG - Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                                    var update = (from u in cont.SANPHAMs where u.MASP == b.MASP select u).Single();
                                    update.SOLUONG = b.SOLUONG;
                                    cont.SaveChanges();
                                    break;
                                }
                            }
                            ctsp.SOLUONG = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[4].Value);
                            using (var db = new FahasaContextDB())
                            {
                                db.CHITIETHOADONSPs.Add(ctsp);
                                db.SaveChanges();
                            }
                            hoadon = new Hoadon();
                            hoadon.Mahd = Mahd;
                            hoadon.Ngaylap = (Convert.ToDateTime(dgv_Invoice.Rows[i].Cells[0].Value.ToString())).ToShortDateString();
                            hoadon.Ma = ctsp.MASP;
                            hoadon.Tensp = dgv_Invoice.Rows[i].Cells[2].Value.ToString();
                            hoadon.Giaban = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[3].Value);
                            hoadon.Soluong = Convert.ToInt32(ctsp.SOLUONG);
                            hoadon.Thanhtien = Convert.ToInt32(dgv_Invoice.Rows[i].Cells[5].Value);
                            hoadon.Tensach = "";
                            listHoadonxuat.Add(hoadon);
                        }
                    }
                }
                dtInvoice.Clear();
                dgv_Invoice.DataSource = dtInvoice;
            }
            else
            {
                MessageBox.Show("Ngày nhập phải giống nhau!");
            }
        }
        private void btn_Export_Invoice_Click(object sender, EventArgs e)
        {
            if (dgv_Invoice.RowCount != 0)
            {
                if (Ktluu() != "")
                {
                    DialogResult dlr = MessageBox.Show("Bạn đã chắc chắc sản phẩm cần mua?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dlr == DialogResult.OK)
                    {
                        Luu();
                        FrmHoadon a = new FrmHoadon();
                        a.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ngày lập hóa đơn phải giống nhau!");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập hóa đơn!");
            }
        }
        int Tongtien()
        {
            int t = 0;
            for (int i = 0; i < dgv_Invoice.RowCount; i++)
            {
                t = t + Convert.ToInt32( dgv_Invoice.Rows[i].Cells[5].Value);
            }
            return t;
        }
    }
}
