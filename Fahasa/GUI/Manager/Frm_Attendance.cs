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

namespace Fahasa_Management_System.GUI.Manager
{
    public partial class Frm_Attendance : Form
    {
        private int Kt=1;
        private string  MaNV="";
        string Ngaylam = "";
        static public List<Tinhluong> listLuong ;
        DataTable dtEmployee;
        DataTable dtAttendance;
        public Frm_Attendance()
        {
            InitializeComponent();
        }
        void ThemdgvEmployee()
        {
            dtEmployee.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
            foreach (NHANVIEN a in listNhanvien)
            {
                dtEmployee.Rows.Add(new object[] { a.MANV, a.TENNV });
            }
        }

        private void Frm_Attendance_Load(object sender, EventArgs e)
        {
            dtEmployee = new DataTable("employee");
            dtEmployee.Columns.Add("Mã nhân viên", System.Type.GetType("System.Int32"));
            dtEmployee.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            ThemdgvEmployee();
            dtAttendance = new DataTable("attendance");
            dtAttendance.Columns.Add("Mã nhân viên", System.Type.GetType("System.Int32"));
            dtAttendance.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dtAttendance.Columns.Add("Ngày làm", System.Type.GetType("System.DateTime"));
            ThemdgvAttendanc();
            dgv_Employee.DataSource = dtEmployee;
            dgv_Attendance.DataSource = dtAttendance;
            dtp_Attendacne_Date.Value = DateTime.Now;
            dtp_Attendacne_Date.MaxDate = DateTime.Now;
        }
        void ThemdgvAttendanc()
        {
            dtAttendance.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
            List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
            foreach (CHAMCONG a in listChamcong)
            {
                string TenNV = "";
                foreach (NHANVIEN b in listNhanvien)
                {
                    if (a.MANV == b.MANV)
                    {
                        TenNV = b.TENNV;
                    }
                }
                dtAttendance.Rows.Add(new object[] { a.MANV, TenNV, a.NGAYLAM.Value.ToShortDateString() });
            }
        }
        int KtThemvaoChamCong(int Manv)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
            foreach (CHAMCONG a in listChamcong)
            {
                if (Manv == a.MANV && a.NGAYLAM.Value.ToShortDateString() == dtp_Attendacne_Date.Value.ToShortDateString())
                {
                    t = 0;
                    break;
                }
            }
            return t;
        }
        void ThemChamCong()
        {
            string kt = "";
            for (int i = 0; i < dgv_Employee.RowCount; i++)
            {
                dgv_Employee.Rows[i].Cells[0].Value = Convert.ToBoolean(dgv_Employee.Rows[i].Cells[0].Value);
                if (Convert.ToBoolean(dgv_Employee.Rows[i].Cells[0].Value))
                {
                    int Manv = Convert.ToInt32(dgv_Employee.Rows[i].Cells[1].Value);
                    if (KtThemvaoChamCong(Manv) == 1)
                    {
                        CHAMCONG a = new CHAMCONG();
                        a.MANV = Convert.ToInt32(dgv_Employee.Rows[i].Cells[1].Value);
                        a.NGAYLAM = dtp_Attendacne_Date.Value;
                        using (var db = new FahasaContextDB())
                        {
                            db.CHAMCONGs.Add(a);
                            db.SaveChanges();
                        }
                        kt = kt + dgv_Employee.Rows[i].Cells[2].Value.ToString() + " đã được chấm công ngày " + dtp_Attendacne_Date.Value.ToShortDateString() + "\n";
                    }
                    else
                    {
                        kt = kt + dgv_Employee.Rows[i].Cells[2].Value.ToString() + " đã được chấm công trước đó!\n";
                    }
                }
                dgv_Employee.Rows[i].Cells[0].Value = false;
            }
            if (kt != "")
            {
                MessageBox.Show(kt);
            }
        }
        void Chamcong()
        {
            int n = 1;
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
            if (cbo_Salary_Month.Text == "Tháng") t = 0;
            if (t == 1)
            {
                foreach (CHAMCONG a in listChamcong)
                {
                    if (Convert.ToInt32(a.NGAYLAM.Value.Month) == Convert.ToInt32(cbo_Salary_Month.Text))
                    {
                        n = n + 1;
                    }
                }
                int[] Manv = new int[n];
                int x = 0;
                foreach (CHAMCONG a in listChamcong)
                {
                    if (Convert.ToInt32(a.NGAYLAM.Value.Month) == Convert.ToInt32(cbo_Salary_Month.Text))
                    {
                        Manv[x] = Convert.ToInt32(a.MANV);
                        x = x + 1;
                    }
                }
                int[] Dem = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Dem[i] = 1;
                }
                listLuong = new List<Tinhluong>();
                for (int i = 0; i < n-1; i++)
                {
                    int count=1;
                    if (Dem[i]==1)
                    {
                        Dem[i] = 0;
                        for(int j = i + 1; j< n; j++)
                        {
                            if (Manv[j] == Manv[i])
                            {
                                count++;
                                Dem[j] = 0;
                            }
                        }
                        Tinhluong tinglg = new Tinhluong();
                        tinhluong(Manv[i], count);
                        double luong = tinhluong(Manv[i], count);
                        List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
                        string Teenv = "";
                        foreach (NHANVIEN a in listNhanvien)
                        {
                            if (Manv[i] == a.MANV)
                            {
                                Teenv = a.TENNV.ToString();
                            }
                        }
                        tinglg.Songay = count;
                        tinglg.Thang = Convert.ToInt32(cbo_Salary_Month.Text);
                        tinglg.Manv = Manv[i];
                        tinglg.Tennv = Teenv;
                        tinglg.Tien = Convert.ToInt32(luong);
                        listLuong.Add(tinglg);
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn tháng!");
                Kt = 0;
            }
        }
        double tinhluong(int Manv, int Songay)
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<THONGTINCV> listThongtincv = cont.THONGTINCVs.ToList();
            List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
            double Hesoluong = 0.0;
            foreach (THONGTINCV a in listThongtincv)
            {
                int Macv = 0;
                foreach (NHANVIEN b in listNhanvien)
                {
                    if (Manv == b.MANV) Macv = Convert.ToInt32(b.MACV);
                }
                if (Macv == a.MACV) Hesoluong = Convert.ToDouble(a.HESOLUONG);
            }
            double luong = Songay * Hesoluong * 100000;
            return luong;
        }

        private void btn_Add_Attendance_Click(object sender, EventArgs e)
        {
            ThemChamCong();
            ThemdgvAttendanc();
        }

        private void btn_Export_Salary_Report_Click(object sender, EventArgs e)
        {
            Chamcong();
            if (Kt != 0)
            {
                frmTinhluong a = new frmTinhluong();
                a.Show();
                cbo_Salary_Month.Text = "Tháng";
            }
            Kt = 1;
        }

        private void btnXoaChamcong_Click(object sender, EventArgs e)
        {
            int t = 1;
            if (MaNV == "" && Ngaylam == "") t = 0;
            FahasaContextDB cont = new FahasaContextDB();
            int Macc = 0;
            if (t == 1)
            {
                List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
                foreach (CHAMCONG a in listChamcong)
                {
                    if (a.MANV == Convert.ToInt32(MaNV) && a.NGAYLAM.Value.ToShortDateString() == Ngaylam)
                    {
                        Macc = a.MACC;
                    }
                }
                var delete = (from a in cont.CHAMCONGs where (a.MACC == Macc) select a).Single();
                cont.CHAMCONGs.Remove(delete);
                cont.SaveChanges();
                Macc = 0;
                Ngaylam = "";
                MaNV = "";
                ThemdgvAttendanc();
                MessageBox.Show("Đã xóa thành công!");
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }

        private void dgv_Attendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Ngaylam = dgv_Attendance.Rows[e.RowIndex].Cells["Ngày làm"].FormattedValue.ToString();
                MaNV= dgv_Attendance.Rows[e.RowIndex].Cells["Mã nhân viên"].FormattedValue.ToString();
            }
        }
    }
}
