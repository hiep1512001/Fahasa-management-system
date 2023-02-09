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
    public partial class Frm_Employee_Detail : Form
    {
        private int MaNV=0;
        private DataTable dtEmployee;
        public Frm_Employee_Detail()
        {
            InitializeComponent();
        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Frm_Employee_Detail_Load(object sender, EventArgs e)
        {
            FahasaContextDB cont = new FahasaContextDB();
            List<THONGTINCV> listThongtincv = cont.THONGTINCVs.ToList();
            dtEmployee = new DataTable("dtemployee");
            dtEmployee.Columns.Add("Mã nhân viên", System.Type.GetType("System.Int32"));
            dtEmployee.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Địa chỉ", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dtEmployee.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
            dtEmployee.Columns.Add("Công việc", System.Type.GetType("System.String"));
            ThemdvgEmployee();
            foreach(THONGTINCV a in listThongtincv)
            {
                cbo_Work_Type.Items.Add(a.TENCV);
            }
            dtp_Begin_Date.Value = DateTime.Now;
            dgv_Employee.DataSource = dtEmployee;
            dtp_Begin_Date.MaxDate = DateTime.Now;
            dtp_Day_of_Birth.MaxDate = DateTime.Now;
            dtp_Day_of_Birth.MaxDate = dtp_Begin_Date.MaxDate.AddYears(-18);
        }
        void ThemdvgEmployee()
        {
            dtEmployee.Clear();
            FahasaContextDB cont = new FahasaContextDB();
            List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
            List<THONGTINCV> listThongtincv = cont.THONGTINCVs.ToList();
            foreach (NHANVIEN a in listNhanvien)
            {
                string Tencv = "";
                foreach(THONGTINCV b in listThongtincv)
                {
                    if (a.MACV == b.MACV)
                    {
                        Tencv = b.TENCV;
                    }
                }
                dtEmployee.Rows.Add(new object[] { a.MANV, a.TENNV,a.NGAYSINH.Value.ToShortDateString(),a.DIACHI,a.SDT,a.NGAYVAOLAM.Value.ToShortDateString(), Tencv});
            }
        }
        void ThemEmployee()
        {
            Resetlable();
            FahasaContextDB cont = new FahasaContextDB();
            List<THONGTINCV> listThongtincv = cont.THONGTINCVs.ToList();
            string Kt = "";
            if (txt_Fullname.Text == "")
            {
                Kt = Kt + "Chưa điền tên!\n";
            }
            if (txt_Address.Text == "")
            {
                Kt = Kt + "Chưa điền địa chỉ!\n";
            }
            if (txt_Phone.Text == "")
            {
                Kt = Kt + "Chưa điền số điện thoại!\n";
            }
            if(cbo_Work_Type.Text== "Vị trí công việc")
            {
                Kt = Kt + "Chưa chọn công việc!\n";
            }
            if (dtp_Begin_Date.Value <= dtp_Day_of_Birth.Value)
            {
                Kt = Kt+ "Ngày vào làm phải lớn hơn ngày sinh!";
            }
            if ((DateTime.Now.Year - dtp_Day_of_Birth.Value.Year) < 18)
            {
                Kt = Kt + "Phải lớn hơn 18 tuổi!";
            }
            if (txt_Phone.Text.Length != 10)
            {
                Kt = Kt + "Số điện thoại không hợp lệ!";
            }
            if (Kt == "")
            {
                NHANVIEN a = new NHANVIEN();
                a.TENNV = txt_Fullname.Text;
                a.NGAYSINH = dtp_Day_of_Birth.Value;
                a.DIACHI = txt_Address.Text;
                a.SDT = txt_Phone.Text.Trim();
                a.NGAYVAOLAM = dtp_Begin_Date.Value;
                foreach(THONGTINCV b in listThongtincv)
                {
                    if (cbo_Work_Type.Text == b.TENCV)
                    {
                        a.MACV = b.MACV;
                    }
                }
                int t = 1;
                List<NHANVIEN> listNhanvien = cont.NHANVIENs.ToList();
                foreach (NHANVIEN b in listNhanvien)
                {
                    if (b.TENNV ==a.TENNV && b.SDT.Trim() == a.SDT)
                    {
                        t = 0;
                        MessageBox.Show("Trùng thông tin nhân viên!");
                        break;
                    }
                    if (b.SDT.Trim() == a.SDT)
                    {
                        t = 0;
                        lblSdt.Text = "Trùng số điện thoại đã có!";
                        break;
                    }
                }
                if (t == 1)
                {
                    using (var db = new FahasaContextDB())
                    {
                        db.NHANVIENs.Add(a);
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
        private void btn_Add_Invoice_Click(object sender, EventArgs e)
        {
            ThemEmployee();
            ThemdvgEmployee();
        }
        int Ktxoa(int manv)
        {
            int t = 1;
            FahasaContextDB cont = new FahasaContextDB();
            List<CHAMCONG> listChamcong = cont.CHAMCONGs.ToList();
            foreach(CHAMCONG a in listChamcong)
            {
                if (manv == a.MANV)
                {
                    t = 0;
                }
            }
            return t;
        }
        void Xoa()
        {
            FahasaContextDB cont = new FahasaContextDB();
            if (MaNV != 0)
            {
                if (Ktxoa(MaNV) == 1)
                {
                    var delete = (from a in cont.NHANVIENs where (a.MANV == MaNV) select a).Single();
                    cont.NHANVIENs.Remove(delete);
                    cont.SaveChanges();
                    MaNV = 0;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể xóa thông tin của nhân viên, vì nhân viên đã được tính công!\nĐể xóa nhân viên phải thực hiện xóa chấm công trước!");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng cần xóa!");
            }
        }
        private void btn_Delete_Invoice_Click(object sender, EventArgs e)
        {
            Xoa();
            ThemdvgEmployee();
            Resetvalue();
            btn_Add_Invoice.Enabled = true;
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MaNV = Convert.ToInt32(dgv_Employee.Rows[e.RowIndex].Cells["Mã nhân viên"].FormattedValue.ToString());
                txt_Fullname.Text = dgv_Employee.Rows[e.RowIndex].Cells["Tên nhân viên"].FormattedValue.ToString();
                txt_Address.Text = dgv_Employee.Rows[e.RowIndex].Cells["Địa chỉ"].FormattedValue.ToString();
                txt_Phone.Text = dgv_Employee.Rows[e.RowIndex].Cells["Số điện thoại"].FormattedValue.ToString().Trim();
                dtp_Day_of_Birth.Value =Convert.ToDateTime( dgv_Employee.Rows[e.RowIndex].Cells["Ngày sinh"].FormattedValue.ToString());
                dtp_Begin_Date.Value= Convert.ToDateTime(dgv_Employee.Rows[e.RowIndex].Cells["Ngày vào làm"].FormattedValue.ToString());
                cbo_Work_Type.Text= dgv_Employee.Rows[e.RowIndex].Cells["Công việc"].FormattedValue.ToString();
                btn_Add_Invoice.Enabled = false;
            }
        }
        void Sua()
        {
            string Kt = "";
            if (MaNV == 0)
            {
                Kt = Kt + "Chưa chọn dòng cần sửa!\n";
            }
            if (Kt == "")
            {
                if (txt_Fullname.Text == "")
                {
                    Kt = Kt + "Chưa điền tên!\n";
                }
                if (txt_Address.Text == "")
                {
                    Kt = Kt + "Chưa điền địa chỉ!\n";
                }
                if (txt_Phone.Text == "")
                {
                    Kt = Kt + "Chưa điền số điện thoại!\n";
                }
                if (cbo_Work_Type.Text == "Vị trí công việc")
                {
                    Kt = Kt + "Chưa chọn công việc!\n";
                }
                if (dtp_Begin_Date.Value <= dtp_Day_of_Birth.Value)
                {
                    Kt = Kt + "Ngày vào làm phải lớn hơn ngày sinh!";
                }
                if (Kt == "")
                {
                    int Macv = 0;
                    FahasaContextDB conn = new FahasaContextDB();
                    List<THONGTINCV> listThongtincv = conn.THONGTINCVs.ToList();
                    foreach (THONGTINCV b in listThongtincv)
                    {
                        if (cbo_Work_Type.Text == b.TENCV)
                        {
                            Macv = b.MACV;
                        }
                    }
                    var update = (from u in conn.NHANVIENs where u.MANV == MaNV select u).Single();
                    update.TENNV = txt_Fullname.Text;
                    update.NGAYSINH = dtp_Day_of_Birth.Value;
                    update.DIACHI = txt_Address.Text;
                    update.SDT = txt_Phone.Text.Trim();
                    update.NGAYVAOLAM = dtp_Begin_Date.Value;
                    update.MACV = Macv;
                    conn.SaveChanges();
                    Macv = 0;
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
        private void btn_Update_Invoice_Click(object sender, EventArgs e)
        {
            Sua();
            btn_Add_Invoice.Enabled = true;
            ThemdvgEmployee();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Resetlable();
            Resetvalue();
            MaNV = 0;
            btn_Add_Invoice.Enabled = true;
        }
        void Resetlable()
        {
            lblTen.Text = "";
            lblNgaysinh.Text = "";
            lblDiachi.Text = "";
            lblNgayvaolam.Text = "";
            lblVitricongviec.Text = "";
            lblSdt.Text = "";
        }
        void Resetvalue()
        {
            txt_Fullname.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            cbo_Work_Type.Text = "Vị trí công việc";
        }
        void GoiY()
        {
            if (txt_Fullname.Text == "")
            {
                lblTen.Text= "Chưa điền tên!";
            }
            if (txt_Address.Text == "")
            {
                lblDiachi.Text= "Chưa điền địa chỉ!";
            }
            if (cbo_Work_Type.Text == "Vị trí công việc")
            {
                lblVitricongviec.Text="Chưa chọn công việc!";
            }
            if (dtp_Begin_Date.Value <= dtp_Day_of_Birth.Value)
            {
                lblNgaysinh.Text="Ngày vào làm phải lớn hơn ngày sinh!";
                lblNgayvaolam.Text= "Ngày vào làm phải lớn hơn ngày sinh!";
            }
            if ((DateTime.Now.Year - dtp_Day_of_Birth.Value.Year) < 18)
            {
                lblNgaysinh.Text= "Phải lớn hơn 18 tuổi!";
            }
            if (txt_Phone.Text.Length != 10)
            {
                lblSdt.Text= "Số điện thoại không hợp lệ!";
            }
            if (txt_Phone.Text == "")
            {
                lblSdt.Text = "Chưa điền số điện thoại!";
            }
        }
    }
}
