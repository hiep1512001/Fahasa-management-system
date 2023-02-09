using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Fahasa_Management_System.GUI.Manager;

namespace Fahasa_Management_System
{
    public partial class FrmDoanhthu : Form
    {
        public FrmDoanhthu()
        {
            InitializeComponent();
        }

        private void FrmDoanhthu_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSetDoanhtu", Frm_Invoice.listDoanhthu);
            this.rpvDoanhthu.LocalReport.DataSources.Clear();
            this.rpvDoanhthu.LocalReport.DataSources.Add(rds);
            this.rpvDoanhthu.RefreshReport();
        }
    }
}
