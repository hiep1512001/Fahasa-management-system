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

namespace Fahasa_Management_System
{
    public partial class FrmNxbTl : Form
    {
        private DataTable dtNxb;
        private DataTable dtTheloai;
        private int Matl = 0;
        private int Manxb = 0;
        public FrmNxbTl()
        {
            InitializeComponent();
        }

        private void FrmNxbTl_Load(object sender, EventArgs e)
        {
            dtNxb = new DataTable("dtNcb");
            dtNxb.Columns.Add("Mã nhà xuất bản", System.Type.GetType("System.Int32"));
            dtNxb.Columns.Add("Tên nhà xuất bản", System.Type.GetType("System.String"));
            dtTheloai = new DataTable("dtTl");
            dtTheloai.Columns.Add("Mã thể loại", System.Type.GetType("System.Int32"));
            dtTheloai.Columns.Add("Tên thể loại", System.Type.GetType("System.String"));
            ThemdgvTheloai();
            ThemdgvNxb();
            dgvNxb.DataSource = dtNxb;
            dgvTheloai.DataSource = dtTheloai;
        }
        void ThemdgvNxb()
        {
            dtNxb.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<NXB> listNxb = cont.NXBs.ToList();
            foreach (NXB a in listNxb)
            {
                dtNxb.Rows.Add(new object[] { a.MANXB, a.TENNXB });
            }

        }
        void ThemdgvTheloai()
        {
            dtTheloai.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            foreach (THELOAI a in listTheloai)
            {
                dtTheloai.Rows.Add(new object[] { a.MATL, a.TENTL });
            }
        }
        void ThemNXB()
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<NXB> listNxb = cont.NXBs.ToList();
            string Kt = "";
            if (txtTennxb.Text == "")
            {
                Kt = Kt + "Chưa điền tên nhà cuất bản!\n";
            }

            if (Kt == "")
            {
                NXB a = new NXB();
                a.TENNXB = txtTennxb.Text;
                using (var db = new FahasaContextDB())
                {
                    db.NXBs.Add(a);
                    db.SaveChanges();
                }
                txtTennxb.Text = "";
            }
            else
            {
                MessageBox.Show(Kt);
            }
        }
        private void btnThemnxb_Click(object sender, EventArgs e)
        {
            ThemNXB();
            ThemdgvNxb();
        }
        void ThemTheloai()
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<THELOAI> listTheloai = cont.THELOAIs.ToList();
            string Kt = "";
            if (txtTentheloai.Text == "")
            {
                Kt = Kt + "Chưa điền tên thể loại!\n";
            }

            if (Kt == "")
            {
                THELOAI a = new THELOAI();
                a.TENTL = txtTentheloai.Text;
                using (var db = new FahasaContextDB())
                {
                    db.THELOAIs.Add(a);
                    db.SaveChanges();
                }
                txtTentheloai.Text = "";
            }
            else
            {
                MessageBox.Show(Kt);
            }
        }

        private void btnThemtheloai_Click(object sender, EventArgs e)
        {
            ThemTheloai();
            ThemdgvTheloai();
        }
        int KtxoaTl(int Matl)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            foreach (SACH a in listSach)
            {
                if (Matl == a.MATL)
                {
                    t = 0;
                }
            }
            return t;
        }
        int KtxoaNxb(int maNxb)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<SACH> listSach = cont.SACHes.ToList();
            foreach (SACH a in listSach)
            {
                if (maNxb == a.MANXB)
                {
                    t = 0;
                }
            }
            return t;
        }

        private void dgvNxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
               Manxb= Convert.ToInt32(dgvNxb.Rows[e.RowIndex].Cells["Mã nhà xuất bản"].FormattedValue.ToString());
            }
        }

        private void dgvTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Matl = Convert.ToInt32(dgvTheloai.Rows[e.RowIndex].Cells["Mã thể loại"].FormattedValue.ToString());
            }
        }
        void XoaNxb()
        {
            FahasaContextDB cont = new FahasaContextDB();
            if (Manxb != 0)
            {
                if (KtxoaNxb(Manxb) == 1)
                {
                    var delete = (from a in cont.NXBs where (a.MANXB == Manxb) select a).Single();
                    cont.NXBs.Remove(delete);
                    cont.SaveChanges();
                    Manxb = 0;
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin nhà xuất bản!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }

        void XoaTl()
        {
            FahasaContextDB cont = new FahasaContextDB();
            if (Matl != 0)
            {
                if (KtxoaTl(Matl)== 1)
                {
                    var delete = (from a in cont.THELOAIs where (a.MATL== Matl) select a).Single();
                    cont.THELOAIs.Remove(delete);
                    cont.SaveChanges();
                    Matl = 0;
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin thể loại sách!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btnXoanxb_Click(object sender, EventArgs e)
        {
            XoaNxb();
            ThemdgvNxb();
        }

        private void btnXoatheloai_Click(object sender, EventArgs e)
        {
            XoaTl();
            ThemdgvTheloai();
        }
    }
}
