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

namespace Fahasa_Management_System.GUI.Employee
{
    public partial class Frm_Product : Form
    {
        private DataTable dtProduct;

        public Frm_Product()
        {
            InitializeComponent();
        }

        private void txt_Find_Product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //
                //Search Function
                //
            }
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
            foreach (NHOMSP a in listNhomsp)
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
        void LoadDB(List<SANPHAM> listsp)
        {
            dtProduct.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach (SANPHAM a in listsp)
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
        private void txt_Find_Product_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_Find_Product.Text.Trim();
            FahasaContextDB contextDB = new FahasaContextDB();
            List<SANPHAM> listPd = new List<SANPHAM>();
            List<SANPHAM> products = contextDB.SANPHAMs.ToList();
            foreach (SANPHAM product in products)
            {
                if (product.TENSP.Contains(keyWord))
                {
                    listPd.Add(product);
                }
            }
            LoadDB(listPd);
            cbo_Product_Type.Text = "Loại Sản phẩm:";
        }
        void Loc()
        {
            string Loaisp = cbo_Product_Type.Text;
            int Maloai = 0;
            dtProduct.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach (NHOMSP a in listNhomsp)
            {
                if (Loaisp == a.TENNHOM)
                {
                    Maloai = a.MANHOM;
                    break;
                }
            }
            foreach (SANPHAM a in listSanpham)
            {
                if (a.MANHOM == Maloai)
                {
                    dtProduct.Rows.Add(new object[] { a.MASP, a.TENSP, Loaisp, a.GIAMUA, a.GIABAN, a.SOLUONG });
                }
            }
        }
        void Loctheogia(int tu,int den)
        {
            dtProduct.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<SANPHAM> listSanpham = cont.SANPHAMs.ToList();
            List<NHOMSP> listNhomsp = cont.NHOMSPs.ToList();
            foreach (SANPHAM a in listSanpham)
            {
                if(tu<=a.GIABAN && a.GIABAN <= den)
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
            cbo_Product_Type.Text = "Loại Sản phẩm:";
            txt_Find_Product.Text = "";
        }

        private void rdBtn_Price_Type1_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(0,100000);
        }

        private void rdBtn_Price_Type2_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(100000, 200000);
        }

        private void rdBtn_Price_Type3_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(200000, 300000);
        }

        private void rdBtn_Price_Type4_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(300000, 100000000);
        }

        private void cbo_Product_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loc();
        }
    }
}
