
namespace Fahasa_Management_System
{
    partial class FrmDoanhthu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DoanthungayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DoanthungayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoanthungayBindingSource
            // 
            this.DoanthungayBindingSource.DataSource = typeof(Fahasa_Management_System.Doanthungay);
            // 
            // rpvDoanhthu
            // 
            this.rpvDoanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDoanhtu";
            reportDataSource1.Value = this.DoanthungayBindingSource;
            this.rpvDoanhthu.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDoanhthu.LocalReport.ReportEmbeddedResource = "Fahasa_Management_System.RDLCDoanthungay.rdlc";
            this.rpvDoanhthu.Location = new System.Drawing.Point(0, 0);
            this.rpvDoanhthu.Name = "rpvDoanhthu";
            this.rpvDoanhthu.ServerReport.BearerToken = null;
            this.rpvDoanhthu.Size = new System.Drawing.Size(1172, 568);
            this.rpvDoanhthu.TabIndex = 0;
            // 
            // FrmDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 568);
            this.Controls.Add(this.rpvDoanhthu);
            this.Name = "FrmDoanhthu";
            this.Text = "FrmDoanhthu";
            this.Load += new System.EventHandler(this.FrmDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoanthungayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDoanhthu;
        private System.Windows.Forms.BindingSource DoanthungayBindingSource;
    }
}