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
    public partial class Frm_Book : Form
    {
        private DataTable dtSach;
        public Frm_Book()
        {
            InitializeComponent();
        }

        private void txt_Find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== (char)Keys.Enter)
            {
                //
                //Search Function
                //
            }

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
            foreach (THELOAI a in listTheloai)
            {
                cbo_Book_Type.Items.Add(a.TENTL);
            }
            foreach (NXB a in listNxb)
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
                dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Theloai, Tennxb, a.GIAMUA, a.GIABAN, a.SOLUONG });
            }
        }

        private void cbo_Book_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            string Loaisp = cbo_Book_Type.Text;
            int Maloai = 0;
            dtSach.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            List<SACH> listsach = cont.SACHes.ToList();
            foreach (THELOAI a in listTheloai)
            {
                if (Loaisp == a.TENTL)
                {
                    Maloai = a.MATL;
                    break;
                }
            }
            foreach (SACH a in listsach)
            {
                string tennxb = "";
                foreach(NXB b in listNxb)
                {
                    if (a.MANXB==b.MANXB)
                    {
                        tennxb = b.TENNXB;
                    }
                }
                if (a.MATL == Maloai)
                {
                    dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Loaisp, tennxb, a.GIAMUA, a.GIABAN, a.SOLUONG });
                }
            }
            cbo_Publishing.Text = "Nhà XB";
        }

        private void cbo_Publishing_SelectedValueChanged(object sender, EventArgs e)
        {
            string Tennxb = cbo_Publishing.Text;
            int MaNXB = 0;
            dtSach.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            List<SACH> listsach = cont.SACHes.ToList();
            foreach (NXB a in listNxb)
            {
                if (Tennxb == a.TENNXB)
                {
                    MaNXB = a.MANXB;
                    break;
                }
            }
            foreach (SACH a in listsach)
            {
                string Tenloai = "";
                foreach (THELOAI b in listTheloai)
                {
                    if (a.MATL == b.MATL)
                    {
                        Tenloai = b.TENTL;
                    }
                }
                if (a.MANXB==MaNXB)
                {
                    dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Tenloai, Tennxb, a.GIAMUA, a.GIABAN, a.SOLUONG });
                }
            }
            cbo_Book_Type.Text = "Thể loại";
        }
        void Loctheogia(int tu, int den)
        {
            dtSach.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            List<SACH> listsach = cont.SACHes.ToList();
            foreach (SACH a in listsach)
            {
                if (tu <= a.GIABAN && a.GIABAN <= den)
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
                    dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Theloai, Tennxb, a.GIAMUA, a.GIABAN, a.SOLUONG });
                }
            }
        }

        private void rdBtn_Price_Type1_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(0, 100000);
            cbo_Publishing.Text = "Nhà XB";
            cbo_Book_Type.Text = "Thể loại";
        }

        private void rdBtn_Price_Type2_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(100000, 200000);
            cbo_Publishing.Text = "Nhà XB";
            cbo_Book_Type.Text = "Thể loại";
        }

        private void rdBtn_Price_Type3_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(200000, 300000);
            cbo_Publishing.Text = "Nhà XB";
            cbo_Book_Type.Text = "Thể loại";
        }

        private void rdBtn_Price_Type4_CheckedChanged(object sender, EventArgs e)
        {
            Loctheogia(300000, 10000000);
            cbo_Publishing.Text = "Nhà XB";
            cbo_Book_Type.Text = "Thể loại";
        }
        void LoadDB(List<SACH> listsa)
        {
            dtSach.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTl = cont.THELOAIs.ToList();
            List<NXB> listNxb = cont.NXBs.ToList();
            foreach (SACH a in listsa)
            {
                string Theloai = "";
                string Tennxb = "";
                foreach (THELOAI b in listTl)
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
                dtSach.Rows.Add(new object[] { a.MASACH, a.TENSACH, Theloai, Tennxb, a.GIAMUA, a.GIABAN, a.SOLUONG });
            }
        }
        private void txt_Find_Book_TextChanged(object sender, EventArgs e)
        {
            string keyWord = txt_Find_Book.Text.Trim();
            FahasaContextDB contextDB = new FahasaContextDB();
            List<SACH> listPd = new List<SACH>() ;
            List<SACH> listsa = contextDB.SACHes.ToList();
            foreach (SACH sa in listsa)
            {
                if (sa.TENSACH.Contains(keyWord))
                {
                    listPd.Add(sa);
                }
            }
            LoadDB(listPd);
            cbo_Publishing.Text = "Nhà XB";
            cbo_Book_Type.Text = "Thể loại";
        }
    }
}
