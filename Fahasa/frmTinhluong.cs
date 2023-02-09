using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fahasa_Management_System.GUI.Manager;
using Microsoft.Reporting.WinForms;

namespace Fahasa_Management_System
{
    public partial class frmTinhluong : Form
    {
        public frmTinhluong()
        {
            InitializeComponent();
        }
        private void frmTinhluong_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("data1", Frm_Attendance.listLuong);
            this.rpvLuong.LocalReport.DataSources.Clear();
            this.rpvLuong.LocalReport.DataSources.Add(rds);
            this.rpvLuong.RefreshReport();
        }
    }
}
