
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Buy_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Buy_Invoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_DoB = new Guna.UI.WinForms.GunaLabel();
            this.numUD_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbo_Product_Name = new System.Windows.Forms.ComboBox();
            this.cbo_Product_Type = new System.Windows.Forms.ComboBox();
            this.dtp_Invoice_Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbo_Book_Name = new System.Windows.Forms.ComboBox();
            this.cbo_Book_Type = new System.Windows.Forms.ComboBox();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Export_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_Invoice = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Invoice = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Invoice_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Buy_Invoice = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Total = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_Total_Amount = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.gr_Button.SuspendLayout();
            this.pnl_Invoice.SuspendLayout();
            this.pnl_Invoice_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buy_Invoice)).BeginInit();
            this.pnl_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.Controls.Add(this.gr_Information);
            this.pnl_Detail.Controls.Add(this.gr_Button);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Detail.Location = new System.Drawing.Point(8, 8);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Detail.ShadowDecoration.Parent = this.pnl_Detail;
            this.pnl_Detail.Size = new System.Drawing.Size(260, 520);
            this.pnl_Detail.TabIndex = 5;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Information.Controls.Add(this.txt_Price);
            this.gr_Information.Controls.Add(this.gunaLabel1);
            this.gr_Information.Controls.Add(this.lbl_DoB);
            this.gr_Information.Controls.Add(this.numUD_Quantity);
            this.gr_Information.Controls.Add(this.cbo_Product_Name);
            this.gr_Information.Controls.Add(this.cbo_Product_Type);
            this.gr_Information.Controls.Add(this.dtp_Invoice_Date);
            this.gr_Information.Controls.Add(this.cbo_Book_Name);
            this.gr_Information.Controls.Add(this.cbo_Book_Type);
            this.gr_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Information.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Information.ForeColor = System.Drawing.Color.White;
            this.gr_Information.Location = new System.Drawing.Point(8, 8);
            this.gr_Information.Name = "gr_Information";
            this.gr_Information.Padding = new System.Windows.Forms.Padding(4);
            this.gr_Information.ShadowDecoration.Parent = this.gr_Information;
            this.gr_Information.Size = new System.Drawing.Size(244, 322);
            this.gr_Information.TabIndex = 5;
            this.gr_Information.Text = "Nhập thông tin";
            this.gr_Information.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(7, 207);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 36);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Số lượng:";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_DoB.Location = new System.Drawing.Point(7, 50);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(83, 36);
            this.lbl_DoB.TabIndex = 7;
            this.lbl_DoB.Text = "Ngày lập:";
            this.lbl_DoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUD_Quantity
            // 
            this.numUD_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numUD_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.numUD_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUD_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numUD_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numUD_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numUD_Quantity.DisabledState.Parent = this.numUD_Quantity;
            this.numUD_Quantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numUD_Quantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numUD_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.numUD_Quantity.FocusedState.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.numUD_Quantity.Location = new System.Drawing.Point(96, 207);
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.ShadowDecoration.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Size = new System.Drawing.Size(141, 36);
            this.numUD_Quantity.TabIndex = 6;
            this.numUD_Quantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.numUD_Quantity.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbo_Product_Name
            // 
            this.cbo_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Product_Name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Product_Name.ItemHeight = 20;
            this.cbo_Product_Name.Location = new System.Drawing.Point(123, 157);
            this.cbo_Product_Name.Name = "cbo_Product_Name";
            this.cbo_Product_Name.Size = new System.Drawing.Size(114, 28);
            this.cbo_Product_Name.Sorted = true;
            this.cbo_Product_Name.TabIndex = 5;
            this.cbo_Product_Name.Text = "Tên SP";
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Product_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Product_Type.ItemHeight = 20;
            this.cbo_Product_Type.Location = new System.Drawing.Point(7, 157);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.Size = new System.Drawing.Size(114, 28);
            this.cbo_Product_Type.Sorted = true;
            this.cbo_Product_Type.TabIndex = 4;
            this.cbo_Product_Type.Text = "Loại SP";
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
            this.dtp_Invoice_Date.Location = new System.Drawing.Point(96, 50);
            this.dtp_Invoice_Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Invoice_Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Invoice_Date.Name = "dtp_Invoice_Date";
            this.dtp_Invoice_Date.ShadowDecoration.Parent = this.dtp_Invoice_Date;
            this.dtp_Invoice_Date.Size = new System.Drawing.Size(141, 36);
            this.dtp_Invoice_Date.TabIndex = 3;
            this.dtp_Invoice_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_Invoice_Date.Value = new System.DateTime(2021, 10, 26, 10, 24, 27, 348);
            // 
            // cbo_Book_Name
            // 
            this.cbo_Book_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Book_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Book_Name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Book_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Book_Name.ItemHeight = 20;
            this.cbo_Book_Name.Location = new System.Drawing.Point(123, 107);
            this.cbo_Book_Name.Name = "cbo_Book_Name";
            this.cbo_Book_Name.Size = new System.Drawing.Size(114, 28);
            this.cbo_Book_Name.Sorted = true;
            this.cbo_Book_Name.TabIndex = 2;
            this.cbo_Book_Name.Text = "Tên sách";
            // 
            // cbo_Book_Type
            // 
            this.cbo_Book_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Book_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Book_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Book_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Book_Type.ItemHeight = 20;
            this.cbo_Book_Type.Location = new System.Drawing.Point(7, 107);
            this.cbo_Book_Type.Name = "cbo_Book_Type";
            this.cbo_Book_Type.Size = new System.Drawing.Size(114, 28);
            this.cbo_Book_Type.Sorted = true;
            this.cbo_Book_Type.TabIndex = 1;
            this.cbo_Book_Type.Text = "Thể loại sách";
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.Controls.Add(this.btn_Export_Invoice);
            this.gr_Button.Controls.Add(this.btn_Delete_Invoice);
            this.gr_Button.Controls.Add(this.btn_Update_Invoice);
            this.gr_Button.Controls.Add(this.btn_Add_Invoice);
            this.gr_Button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(8, 330);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(244, 182);
            this.gr_Button.TabIndex = 4;
            this.gr_Button.Text = "Tác vụ";
            this.gr_Button.TextOffset = new System.Drawing.Point(0, -4);
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
            this.btn_Export_Invoice.Location = new System.Drawing.Point(7, 129);
            this.btn_Export_Invoice.Name = "btn_Export_Invoice";
            this.btn_Export_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Export_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Export_Invoice.OnHoverImage = null;
            this.btn_Export_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Export_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Export_Invoice.Size = new System.Drawing.Size(230, 36);
            this.btn_Export_Invoice.TabIndex = 6;
            this.btn_Export_Invoice.Text = "Xuất";
            this.btn_Export_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Export_Invoice.TextOffsetX = 20;
            // 
            // btn_Delete_Invoice
            // 
            this.btn_Delete_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete_Invoice.Animated = true;
            this.btn_Delete_Invoice.AnimationHoverSpeed = 0.07F;
            this.btn_Delete_Invoice.AnimationSpeed = 0.03F;
            this.btn_Delete_Invoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Delete_Invoice.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Invoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete_Invoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Invoice.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete_Invoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Invoice.CheckedImage")));
            this.btn_Delete_Invoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete_Invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete_Invoice.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete_Invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Invoice.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btn_Delete_Invoice.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Delete_Invoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Invoice.Location = new System.Drawing.Point(129, 87);
            this.btn_Delete_Invoice.Name = "btn_Delete_Invoice";
            this.btn_Delete_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Delete_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Invoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Delete_Invoice.OnHoverImage = null;
            this.btn_Delete_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Invoice.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Invoice.TabIndex = 5;
            this.btn_Delete_Invoice.Text = "Xóa";
            this.btn_Delete_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Invoice.TextOffsetX = 24;
            // 
            // btn_Update_Invoice
            // 
            this.btn_Update_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update_Invoice.Animated = true;
            this.btn_Update_Invoice.AnimationHoverSpeed = 0.07F;
            this.btn_Update_Invoice.AnimationSpeed = 0.03F;
            this.btn_Update_Invoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Update_Invoice.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_Invoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Update_Invoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Invoice.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Update_Invoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Update_Invoice.CheckedImage")));
            this.btn_Update_Invoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Update_Invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update_Invoice.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update_Invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Invoice.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btn_Update_Invoice.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Update_Invoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Invoice.Location = new System.Drawing.Point(7, 87);
            this.btn_Update_Invoice.Name = "btn_Update_Invoice";
            this.btn_Update_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Update_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Invoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Update_Invoice.OnHoverImage = null;
            this.btn_Update_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Invoice.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Invoice.TabIndex = 4;
            this.btn_Update_Invoice.Text = "Sửa";
            this.btn_Update_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update_Invoice.TextOffsetX = 24;
            // 
            // btn_Add_Invoice
            // 
            this.btn_Add_Invoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add_Invoice.Animated = true;
            this.btn_Add_Invoice.AnimationHoverSpeed = 0.07F;
            this.btn_Add_Invoice.AnimationSpeed = 0.03F;
            this.btn_Add_Invoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Add_Invoice.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_Invoice.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_Invoice.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Invoice.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_Invoice.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_Invoice.CheckedImage")));
            this.btn_Add_Invoice.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_Invoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_Invoice.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_Invoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Invoice.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Invoice.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_Invoice.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_Invoice.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Invoice.Location = new System.Drawing.Point(7, 45);
            this.btn_Add_Invoice.Name = "btn_Add_Invoice";
            this.btn_Add_Invoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Add_Invoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_Invoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add_Invoice.OnHoverImage = null;
            this.btn_Add_Invoice.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_Invoice.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_Invoice.Size = new System.Drawing.Size(230, 36);
            this.btn_Add_Invoice.TabIndex = 3;
            this.btn_Add_Invoice.Text = "Thêm ";
            this.btn_Add_Invoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add_Invoice.TextOffsetX = 16;
            // 
            // pnl_Invoice
            // 
            this.pnl_Invoice.Controls.Add(this.pnl_Invoice_Info);
            this.pnl_Invoice.Controls.Add(this.pnl_Total);
            this.pnl_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice.Location = new System.Drawing.Point(268, 8);
            this.pnl_Invoice.Name = "pnl_Invoice";
            this.pnl_Invoice.ShadowDecoration.Parent = this.pnl_Invoice;
            this.pnl_Invoice.Size = new System.Drawing.Size(368, 520);
            this.pnl_Invoice.TabIndex = 6;
            // 
            // pnl_Invoice_Info
            // 
            this.pnl_Invoice_Info.Controls.Add(this.dgv_Buy_Invoice);
            this.pnl_Invoice_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Invoice_Info.Location = new System.Drawing.Point(0, 0);
            this.pnl_Invoice_Info.Name = "pnl_Invoice_Info";
            this.pnl_Invoice_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Invoice_Info.ShadowDecoration.Parent = this.pnl_Invoice_Info;
            this.pnl_Invoice_Info.Size = new System.Drawing.Size(368, 472);
            this.pnl_Invoice_Info.TabIndex = 5;
            // 
            // dgv_Buy_Invoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Buy_Invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Buy_Invoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Buy_Invoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Buy_Invoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Buy_Invoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Buy_Invoice.ColumnHeadersHeight = 32;
            this.dgv_Buy_Invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Buy_Invoice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Buy_Invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Buy_Invoice.EnableHeadersVisualStyles = false;
            this.dgv_Buy_Invoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Buy_Invoice.Location = new System.Drawing.Point(8, 8);
            this.dgv_Buy_Invoice.Name = "dgv_Buy_Invoice";
            this.dgv_Buy_Invoice.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Buy_Invoice.RowHeadersVisible = false;
            this.dgv_Buy_Invoice.RowTemplate.Height = 28;
            this.dgv_Buy_Invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Buy_Invoice.Size = new System.Drawing.Size(352, 456);
            this.dgv_Buy_Invoice.TabIndex = 1;
            this.dgv_Buy_Invoice.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Buy_Invoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Buy_Invoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Buy_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Buy_Invoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Buy_Invoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Buy_Invoice.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Buy_Invoice.ThemeStyle.ReadOnly = false;
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Buy_Invoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(180)))), ((int)(((byte)(85)))));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // pnl_Total
            // 
            this.pnl_Total.Controls.Add(this.txt_Total_Amount);
            this.pnl_Total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Total.Location = new System.Drawing.Point(0, 472);
            this.pnl_Total.Name = "pnl_Total";
            this.pnl_Total.ShadowDecoration.Parent = this.pnl_Total;
            this.pnl_Total.Size = new System.Drawing.Size(368, 48);
            this.pnl_Total.TabIndex = 4;
            // 
            // txt_Total_Amount
            // 
            this.txt_Total_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Total_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Total_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Total_Amount.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Total_Amount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_Amount.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_Total_Amount.Location = new System.Drawing.Point(8, 5);
            this.txt_Total_Amount.Name = "txt_Total_Amount";
            this.txt_Total_Amount.PasswordChar = '\0';
            this.txt_Total_Amount.ReadOnly = true;
            this.txt_Total_Amount.SelectedText = "";
            this.txt_Total_Amount.Size = new System.Drawing.Size(352, 36);
            this.txt_Total_Amount.TabIndex = 0;
            this.txt_Total_Amount.Text = "Tổng tiền: ";
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.Parent = this.txt_Price;
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.FocusedState.Parent = this.txt_Price;
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Price.HoverState.Parent = this.txt_Price;
            this.txt_Price.Location = new System.Drawing.Point(7, 264);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Price.PlaceholderText = "Giá";
            this.txt_Price.SelectedText = "";
            this.txt_Price.ShadowDecoration.Parent = this.txt_Price;
            this.txt_Price.Size = new System.Drawing.Size(230, 36);
            this.txt_Price.TabIndex = 11;
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // Frm_Buy_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(644, 536);
            this.Controls.Add(this.pnl_Invoice);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Buy_Invoice";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Buy_Invoice";
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Invoice.ResumeLayout(false);
            this.pnl_Invoice_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buy_Invoice)).EndInit();
            this.pnl_Total.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_DoB;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUD_Quantity;
        private System.Windows.Forms.ComboBox cbo_Product_Name;
        private System.Windows.Forms.ComboBox cbo_Product_Type;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Invoice_Date;
        private System.Windows.Forms.ComboBox cbo_Book_Name;
        private System.Windows.Forms.ComboBox cbo_Book_Type;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Export_Invoice;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Invoice;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Invoice;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_Invoice;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice;
        private Guna.UI2.WinForms.Guna2Panel pnl_Invoice_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Buy_Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Guna.UI2.WinForms.Guna2Panel pnl_Total;
        private Guna.UI.WinForms.GunaLineTextBox txt_Total_Amount;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
    }
}