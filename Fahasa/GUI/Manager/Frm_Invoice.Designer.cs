
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Date_ = new Guna.UI2.WinForms.Guna2Panel();
            this.chkB_Access_Invoice = new Guna.UI2.WinForms.Guna2CheckBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_Invoice_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDoanthu = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Invoice_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpDoanhthu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Export_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txt_Total_Amount = new Guna.UI.WinForms.GunaLineTextBox();
            this.pnl_Date_.SuspendLayout();
            this.pnl_Invoice_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Date_
            // 
            this.pnl_Date_.Controls.Add(this.chkB_Access_Invoice);
            this.pnl_Date_.Controls.Add(this.gunaLabel2);
            this.pnl_Date_.Controls.Add(this.gunaLabel1);
            this.pnl_Date_.Controls.Add(this.guna2DateTimePicker1);
            this.pnl_Date_.Controls.Add(this.dtp_Invoice_Date);
            this.pnl_Date_.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Date_.Location = new System.Drawing.Point(8, 8);
            this.pnl_Date_.Name = "pnl_Date_";
            this.pnl_Date_.ShadowDecoration.Parent = this.pnl_Date_;
            this.pnl_Date_.Size = new System.Drawing.Size(832, 132);
            this.pnl_Date_.TabIndex = 1;
            // 
            // chkB_Access_Invoice
            // 
            this.chkB_Access_Invoice.AutoSize = true;
            this.chkB_Access_Invoice.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.chkB_Access_Invoice.CheckedState.BorderRadius = 2;
            this.chkB_Access_Invoice.CheckedState.BorderThickness = 0;
            this.chkB_Access_Invoice.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.chkB_Access_Invoice.Location = new System.Drawing.Point(64, 20);
            this.chkB_Access_Invoice.Name = "chkB_Access_Invoice";
            this.chkB_Access_Invoice.Size = new System.Drawing.Size(279, 29);
            this.chkB_Access_Invoice.TabIndex = 9;
            this.chkB_Access_Invoice.Text = "Xem đơn hàng tháng hiện tại";
            this.chkB_Access_Invoice.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_Access_Invoice.UncheckedState.BorderRadius = 2;
            this.chkB_Access_Invoice.UncheckedState.BorderThickness = 0;
            this.chkB_Access_Invoice.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkB_Access_Invoice.UseVisualStyleBackColor = true;
            this.chkB_Access_Invoice.CheckedChanged += new System.EventHandler(this.chkB_Access_Invoice_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel2.Location = new System.Drawing.Point(60, 61);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(155, 25);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "Xem hóa đơn từ: ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(470, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(49, 25);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "đến ";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.guna2DateTimePicker1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(302, 52);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(141, 36);
            this.guna2DateTimePicker1.TabIndex = 5;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // dtp_Invoice_Date
            // 
            this.dtp_Invoice_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Invoice_Date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtp_Invoice_Date.BorderThickness = 1;
            this.dtp_Invoice_Date.CheckedState.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.FillColor = System.Drawing.Color.White;
            this.dtp_Invoice_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtp_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Invoice_Date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.dtp_Invoice_Date.HoverState.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.Location = new System.Drawing.Point(530, 52);
            this.dtp_Invoice_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Invoice_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Invoice_Date.Name = "dtp_Invoice_Date";
            this.dtp_Invoice_Date.ShadowDecoration.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.Size = new System.Drawing.Size(141, 36);
            this.dtp_Invoice_Date.TabIndex = 4;
            this.dtp_Invoice_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Invoice_Date.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            this.dtp_Invoice_Date.ValueChanged += new System.EventHandler(this.dtp_Invoice_Date_ValueChanged);
            // 
            // btnDoanthu
            // 
            this.btnDoanthu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoanthu.Animated = true;
            this.btnDoanthu.AnimationHoverSpeed = 0.07F;
            this.btnDoanthu.AnimationSpeed = 0.03F;
            this.btnDoanthu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnDoanthu.BorderColor = System.Drawing.Color.Black;
            this.btnDoanthu.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDoanthu.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDoanthu.CheckedForeColor = System.Drawing.Color.White;
            this.btnDoanthu.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDoanthu.CheckedImage")));
            this.btnDoanthu.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDoanthu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoanthu.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoanthu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanthu.ForeColor = System.Drawing.Color.White;
            this.btnDoanthu.Image = global::Fahasa_Management_System.Properties.Resources.print;
            this.btnDoanthu.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDoanthu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoanthu.Location = new System.Drawing.Point(174, 8);
            this.btnDoanthu.Name = "btnDoanthu";
            this.btnDoanthu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnDoanthu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDoanthu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDoanthu.OnHoverImage = null;
            this.btnDoanthu.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDoanthu.OnPressedColor = System.Drawing.Color.Black;
            this.btnDoanthu.Size = new System.Drawing.Size(180, 36);
            this.btnDoanthu.TabIndex = 10;
            this.btnDoanthu.Text = "Thống kê doanh thu";
            this.btnDoanthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDoanthu.Click += new System.EventHandler(this.btnDoanthu_Click);
            // 
            // pnl_Invoice_Info
            // 
            this.pnl_Invoice_Info.Controls.Add(this.dgv_Invoice);
            this.pnl_Invoice_Info.Controls.Add(this.guna2Panel2);
            this.pnl_Invoice_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice_Info.Location = new System.Drawing.Point(8, 140);
            this.pnl_Invoice_Info.Name = "pnl_Invoice_Info";
            this.pnl_Invoice_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Invoice_Info.ShadowDecoration.Parent = this.pnl_Invoice_Info;
            this.pnl_Invoice_Info.Size = new System.Drawing.Size(832, 388);
            this.pnl_Invoice_Info.TabIndex = 9;
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Invoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Invoice.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Invoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Invoice.EnableHeadersVisualStyles = false;
            this.dgv_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.Location = new System.Drawing.Point(8, 8);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.ReadOnly = true;
            this.dgv_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.RowHeadersVisible = false;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 28;
            this.dgv_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Invoice.Size = new System.Drawing.Size(816, 320);
            this.dgv_Invoice.TabIndex = 4;
            this.dgv_Invoice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Invoice.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Invoice.ThemeStyle.ReadOnly = true;
            this.dgv_Invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Invoice.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Invoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Invoice_CellClick);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dtpDoanhthu);
            this.guna2Panel2.Controls.Add(this.btnDoanthu);
            this.guna2Panel2.Controls.Add(this.btn_Export_Invoice);
            this.guna2Panel2.Controls.Add(this.txt_Total_Amount);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(8, 328);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(816, 52);
            this.guna2Panel2.TabIndex = 3;
            // 
            // dtpDoanhthu
            // 
            this.dtpDoanhthu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDoanhthu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpDoanhthu.BorderThickness = 1;
            this.dtpDoanhthu.CheckedState.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.FillColor = System.Drawing.Color.White;
            this.dtpDoanhthu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dtpDoanhthu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDoanhthu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.dtpDoanhthu.HoverState.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.Location = new System.Drawing.Point(3, 8);
            this.dtpDoanhthu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDoanhthu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDoanhthu.Name = "dtpDoanhthu";
            this.dtpDoanhthu.ShadowDecoration.Parent = this.dtpDoanhthu;
            this.dtpDoanhthu.Size = new System.Drawing.Size(141, 36);
            this.dtpDoanhthu.TabIndex = 10;
            this.dtpDoanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDoanhthu.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // btn_Export_Invoice
            // 
            this.btn_Export_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Export_Invoice.Animated = true;
            this.btn_Export_Invoice.AnimationHoverSpeed = 0.07F;
            this.btn_Export_Invoice.AnimationSpeed = 0.03F;
            this.btn_Export_Invoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Export_Invoice.BorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Export_Invoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Export_Invoice.CheckedImage")));
            this.btn_Export_Invoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Export_Invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Export_Invoice.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Export_Invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.Image = global::Fahasa_Management_System.Properties.Resources.print;
            this.btn_Export_Invoice.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Export_Invoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.Location = new System.Drawing.Point(385, 8);
            this.btn_Export_Invoice.Name = "btn_Export_Invoice";
            this.btn_Export_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Export_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.OnHoverImage = null;
            this.btn_Export_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.Size = new System.Drawing.Size(180, 36);
            this.btn_Export_Invoice.TabIndex = 9;
            this.btn_Export_Invoice.Text = "Xem hóa đơn chi tiết";
            this.btn_Export_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Export_Invoice.Click += new System.EventHandler(this.btn_Export_Invoice_Click);
            // 
            // txt_Total_Amount
            // 
            this.txt_Total_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Total_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total_Amount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Total_Amount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Amount.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Total_Amount.Location = new System.Drawing.Point(635, 8);
            this.txt_Total_Amount.Name = "txt_Total_Amount";
            this.txt_Total_Amount.PasswordChar = '\0';
            this.txt_Total_Amount.ReadOnly = true;
            this.txt_Total_Amount.SelectedText = "";
            this.txt_Total_Amount.Size = new System.Drawing.Size(178, 36);
            this.txt_Total_Amount.TabIndex = 8;
            this.txt_Total_Amount.Text = "Tổng tiền: ";
            // 
            // Frm_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(848, 536);
            this.Controls.Add(this.pnl_Invoice_Info);
            this.Controls.Add(this.pnl_Date_);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Invoice";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Invoice";
            this.Load += new System.EventHandler(this.Frm_Invoice_Load);
            this.pnl_Date_.ResumeLayout(false);
            this.pnl_Date_.PerformLayout();
            this.pnl_Invoice_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Date_;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice_Info;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Invoice;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Invoice_Date;
        private Guna.UI.WinForms.GunaLineTextBox txt_Total_Amount;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Export_Invoice;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox chkB_Access_Invoice;
        private Guna.UI.WinForms.GunaAdvenceButton btnDoanthu;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDoanhthu;
    }
}