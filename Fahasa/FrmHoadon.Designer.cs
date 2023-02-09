
namespace Fahasa_Management_System
{
    partial class FrmHoadon
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
            this.HoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvHoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoadonBindingSource
            // 
            this.HoadonBindingSource.DataSource = typeof(Fahasa_Management_System.Hoadon);
            // 
            // rpvHoadon
            // 
            this.rpvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetHoadon";
            reportDataSource1.Value = this.HoadonBindingSource;
            this.rpvHoadon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvHoadon.LocalReport.ReportEmbeddedResource = "Fahasa_Management_System.RdlcHoadon.rdlc";
            this.rpvHoadon.Location = new System.Drawing.Point(0, 0);
            this.rpvHoadon.Name = "rpvHoadon";
            this.rpvHoadon.ServerReport.BearerToken = null;
            this.rpvHoadon.Size = new System.Drawing.Size(1148, 546);
            this.rpvHoadon.TabIndex = 0;
            // 
            // FrmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 546);
            this.Controls.Add(this.rpvHoadon);
            this.Name = "FrmHoadon";
            this.Text = "FrmHoadon";
            this.Load += new System.EventHandler(this.FrmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoadonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoadon;
        private System.Windows.Forms.BindingSource HoadonBindingSource;
    }
}