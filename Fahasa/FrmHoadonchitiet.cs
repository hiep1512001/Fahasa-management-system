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
    public partial class FrmHoadonchitiet : Form
    {
        public FrmHoadonchitiet()
        {
            InitializeComponent();
        }

        private void FrmHoadonchitiet_Load(object sender, EventArgs e)
        {

            ReportDataSource rds = new ReportDataSource("DataSetDonhang", Frm_Invoice.listDHchitiet);
            this.rpvHoadonchitiet.LocalReport.DataSources.Clear();
            this.rpvHoadonchitiet.LocalReport.DataSources.Add(rds);
            this.rpvHoadonchitiet.RefreshReport();
        }
    }
}
