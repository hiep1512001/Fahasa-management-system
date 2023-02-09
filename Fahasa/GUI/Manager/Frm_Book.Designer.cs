
namespace Fahasa_Management_System.GUI.Manager
{
    partial class Frm_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Book));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblNxb = new System.Windows.Forms.Label();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.lblGiamua = new System.Windows.Forms.Label();
            this.lblTheloai = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.btnThemnxb = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbl_DoB = new Guna.UI.WinForms.GunaLabel();
            this.numUD_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbo_Publishing = new System.Windows.Forms.ComboBox();
            this.txt_Sell_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Buy_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Book_Title = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_Book_Type = new System.Windows.Forms.ComboBox();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Book = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Book = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_New_Book = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Book_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Book = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.gr_Button.SuspendLayout();
            this.pnl_Book_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
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
            this.pnl_Detail.Size = new System.Drawing.Size(260, 670);
            this.pnl_Detail.TabIndex = 6;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Information.Controls.Add(this.lblSoluong);
            this.gr_Information.Controls.Add(this.lblNxb);
            this.gr_Information.Controls.Add(this.lblGiaban);
            this.gr_Information.Controls.Add(this.lblGiamua);
            this.gr_Information.Controls.Add(this.lblTheloai);
            this.gr_Information.Controls.Add(this.lblTensach);
            this.gr_Information.Controls.Add(this.btnThemnxb);
            this.gr_Information.Controls.Add(this.lbl_DoB);
            this.gr_Information.Controls.Add(this.numUD_Quantity);
            this.gr_Information.Controls.Add(this.cbo_Publishing);
            this.gr_Information.Controls.Add(this.txt_Sell_Price);
            this.gr_Information.Controls.Add(this.txt_Buy_Price);
            this.gr_Information.Controls.Add(this.txt_Book_Title);
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
            this.gr_Information.Size = new System.Drawing.Size(244, 533);
            this.gr_Information.TabIndex = 5;
            this.gr_Information.Text = "Nhập thông tin";
            this.gr_Information.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // lblSoluong
            // 
            this.lblSoluong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoluong.ForeColor = System.Drawing.Color.Red;
            this.lblSoluong.Location = new System.Drawing.Point(90, 437);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(0, 15);
            this.lblSoluong.TabIndex = 19;
            // 
            // lblNxb
            // 
            this.lblNxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNxb.AutoSize = true;
            this.lblNxb.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNxb.ForeColor = System.Drawing.Color.Red;
            this.lblNxb.Location = new System.Drawing.Point(9, 381);
            this.lblNxb.Name = "lblNxb";
            this.lblNxb.Size = new System.Drawing.Size(0, 15);
            this.lblNxb.TabIndex = 18;
            // 
            // lblGiaban
            // 
            this.lblGiaban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaban.ForeColor = System.Drawing.Color.Red;
            this.lblGiaban.Location = new System.Drawing.Point(9, 329);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(0, 15);
            this.lblGiaban.TabIndex = 17;
            // 
            // lblGiamua
            // 
            this.lblGiamua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiamua.AutoSize = true;
            this.lblGiamua.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiamua.ForeColor = System.Drawing.Color.Red;
            this.lblGiamua.Location = new System.Drawing.Point(9, 273);
            this.lblGiamua.Name = "lblGiamua";
            this.lblGiamua.Size = new System.Drawing.Size(0, 15);
            this.lblGiamua.TabIndex = 16;
            // 
            // lblTheloai
            // 
            this.lblTheloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTheloai.AutoSize = true;
            this.lblTheloai.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTheloai.ForeColor = System.Drawing.Color.Red;
            this.lblTheloai.Location = new System.Drawing.Point(9, 212);
            this.lblTheloai.Name = "lblTheloai";
            this.lblTheloai.Size = new System.Drawing.Size(0, 15);
            this.lblTheloai.TabIndex = 15;
            // 
            // lblTensach
            // 
            this.lblTensach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTensach.AutoSize = true;
            this.lblTensach.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTensach.ForeColor = System.Drawing.Color.Red;
            this.lblTensach.Location = new System.Drawing.Point(9, 162);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(0, 15);
            this.lblTensach.TabIndex = 2;
            // 
            // btnThemnxb
            // 
            this.btnThemnxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemnxb.Animated = true;
            this.btnThemnxb.AnimationHoverSpeed = 0.07F;
            this.btnThemnxb.AnimationSpeed = 0.03F;
            this.btnThemnxb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnThemnxb.BorderColor = System.Drawing.Color.Black;
            this.btnThemnxb.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnThemnxb.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnThemnxb.CheckedForeColor = System.Drawing.Color.White;
            this.btnThemnxb.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnThemnxb.CheckedImage")));
            this.btnThemnxb.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnThemnxb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemnxb.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemnxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnxb.ForeColor = System.Drawing.Color.White;
            this.btnThemnxb.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btnThemnxb.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemnxb.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemnxb.Location = new System.Drawing.Point(12, 461);
            this.btnThemnxb.Name = "btnThemnxb";
            this.btnThemnxb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnThemnxb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemnxb.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemnxb.OnHoverImage = null;
            this.btnThemnxb.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemnxb.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemnxb.Size = new System.Drawing.Size(225, 36);
            this.btnThemnxb.TabIndex = 14;
            this.btnThemnxb.Text = "Thêm NXB-Thể loại";
            this.btnThemnxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThemnxb.TextOffsetX = 16;
            this.btnThemnxb.Click += new System.EventHandler(this.btnThemnxb_Click);
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_DoB.Location = new System.Drawing.Point(7, 398);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(83, 36);
            this.lbl_DoB.TabIndex = 13;
            this.lbl_DoB.Text = "Số lượng:";
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
            this.numUD_Quantity.Location = new System.Drawing.Point(91, 398);
            this.numUD_Quantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD_Quantity.Name = "numUD_Quantity";
            this.numUD_Quantity.ShadowDecoration.Parent = this.numUD_Quantity;
            this.numUD_Quantity.Size = new System.Drawing.Size(146, 36);
            this.numUD_Quantity.TabIndex = 12;
            this.numUD_Quantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.numUD_Quantity.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbo_Publishing
            // 
            this.cbo_Publishing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Publishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Publishing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Publishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Publishing.ItemHeight = 25;
            this.cbo_Publishing.Location = new System.Drawing.Point(7, 349);
            this.cbo_Publishing.Name = "cbo_Publishing";
            this.cbo_Publishing.Size = new System.Drawing.Size(230, 33);
            this.cbo_Publishing.Sorted = true;
            this.cbo_Publishing.TabIndex = 11;
            this.cbo_Publishing.Text = "Nhà XB";
            // 
            // txt_Sell_Price
            // 
            this.txt_Sell_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Sell_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sell_Price.DefaultText = "";
            this.txt_Sell_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Sell_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Sell_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sell_Price.DisabledState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sell_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sell_Price.FocusedState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Sell_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Sell_Price.HoverState.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Location = new System.Drawing.Point(7, 291);
            this.txt_Sell_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Sell_Price.Name = "txt_Sell_Price";
            this.txt_Sell_Price.PasswordChar = '\0';
            this.txt_Sell_Price.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Sell_Price.PlaceholderText = "Giá bán:";
            this.txt_Sell_Price.SelectedText = "";
            this.txt_Sell_Price.ShadowDecoration.Parent = this.txt_Sell_Price;
            this.txt_Sell_Price.Size = new System.Drawing.Size(230, 36);
            this.txt_Sell_Price.TabIndex = 10;
            this.txt_Sell_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sell_Price_KeyPress);
            // 
            // txt_Buy_Price
            // 
            this.txt_Buy_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Buy_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Buy_Price.DefaultText = "";
            this.txt_Buy_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Buy_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Buy_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Buy_Price.DisabledState.Parent = this.txt_Buy_Price;
            this.txt_Buy_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Buy_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Buy_Price.FocusedState.Parent = this.txt_Buy_Price;
            this.txt_Buy_Price.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buy_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Buy_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Buy_Price.HoverState.Parent = this.txt_Buy_Price;
            this.txt_Buy_Price.Location = new System.Drawing.Point(7, 233);
            this.txt_Buy_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Buy_Price.Name = "txt_Buy_Price";
            this.txt_Buy_Price.PasswordChar = '\0';
            this.txt_Buy_Price.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Buy_Price.PlaceholderText = "Giá mua:";
            this.txt_Buy_Price.SelectedText = "";
            this.txt_Buy_Price.ShadowDecoration.Parent = this.txt_Buy_Price;
            this.txt_Buy_Price.Size = new System.Drawing.Size(230, 36);
            this.txt_Buy_Price.TabIndex = 9;
            this.txt_Buy_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Buy_Price_KeyPress);
            // 
            // txt_Book_Title
            // 
            this.txt_Book_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Book_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Book_Title.DefaultText = "";
            this.txt_Book_Title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Book_Title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Book_Title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Book_Title.DisabledState.Parent = this.txt_Book_Title;
            this.txt_Book_Title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Book_Title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Book_Title.FocusedState.Parent = this.txt_Book_Title;
            this.txt_Book_Title.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Book_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Book_Title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Book_Title.HoverState.Parent = this.txt_Book_Title;
            this.txt_Book_Title.Location = new System.Drawing.Point(7, 125);
            this.txt_Book_Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Book_Title.Name = "txt_Book_Title";
            this.txt_Book_Title.PasswordChar = '\0';
            this.txt_Book_Title.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Book_Title.PlaceholderText = "Tên sách:";
            this.txt_Book_Title.SelectedText = "";
            this.txt_Book_Title.ShadowDecoration.Parent = this.txt_Book_Title;
            this.txt_Book_Title.Size = new System.Drawing.Size(230, 36);
            this.txt_Book_Title.TabIndex = 8;
            // 
            // cbo_Book_Type
            // 
            this.cbo_Book_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Book_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Book_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Book_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Book_Type.ItemHeight = 25;
            this.cbo_Book_Type.Location = new System.Drawing.Point(7, 182);
            this.cbo_Book_Type.Name = "cbo_Book_Type";
            this.cbo_Book_Type.Size = new System.Drawing.Size(230, 33);
            this.cbo_Book_Type.Sorted = true;
            this.cbo_Book_Type.TabIndex = 1;
            this.cbo_Book_Type.Text = "Thể loại";
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.Controls.Add(this.btnDatlai);
            this.gr_Button.Controls.Add(this.btn_Delete_Book);
            this.gr_Button.Controls.Add(this.btn_Update_Book);
            this.gr_Button.Controls.Add(this.btn_Add_New_Book);
            this.gr_Button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(8, 541);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(244, 121);
            this.gr_Button.TabIndex = 4;
            this.gr_Button.Text = "Tác vụ";
            this.gr_Button.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // btnDatlai
            // 
            this.btnDatlai.Animated = true;
            this.btnDatlai.AnimationHoverSpeed = 0.07F;
            this.btnDatlai.AnimationSpeed = 0.03F;
            this.btnDatlai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnDatlai.BorderColor = System.Drawing.Color.Black;
            this.btnDatlai.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnDatlai.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.CheckedForeColor = System.Drawing.Color.White;
            this.btnDatlai.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnDatlai.CheckedImage")));
            this.btnDatlai.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnDatlai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDatlai.FocusedColor = System.Drawing.Color.Empty;
            this.btnDatlai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatlai.ForeColor = System.Drawing.Color.White;
            this.btnDatlai.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btnDatlai.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDatlai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.Location = new System.Drawing.Point(129, 35);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDatlai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDatlai.OnHoverImage = null;
            this.btnDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.btnDatlai.Size = new System.Drawing.Size(108, 36);
            this.btnDatlai.TabIndex = 5;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDatlai.TextOffsetX = 24;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
            // 
            // btn_Delete_Book
            // 
            this.btn_Delete_Book.Animated = true;
            this.btn_Delete_Book.AnimationHoverSpeed = 0.07F;
            this.btn_Delete_Book.AnimationSpeed = 0.03F;
            this.btn_Delete_Book.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Delete_Book.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Book.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete_Book.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Book.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete_Book.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Book.CheckedImage")));
            this.btn_Delete_Book.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete_Book.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete_Book.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Book.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Book.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btn_Delete_Book.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Delete_Book.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Book.Location = new System.Drawing.Point(129, 77);
            this.btn_Delete_Book.Name = "btn_Delete_Book";
            this.btn_Delete_Book.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Delete_Book.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Book.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Delete_Book.OnHoverImage = null;
            this.btn_Delete_Book.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Book.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Book.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Book.TabIndex = 5;
            this.btn_Delete_Book.Text = "Xóa";
            this.btn_Delete_Book.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Book.TextOffsetX = 24;
            this.btn_Delete_Book.Click += new System.EventHandler(this.btn_Delete_Book_Click);
            // 
            // btn_Update_Book
            // 
            this.btn_Update_Book.Animated = true;
            this.btn_Update_Book.AnimationHoverSpeed = 0.07F;
            this.btn_Update_Book.AnimationSpeed = 0.03F;
            this.btn_Update_Book.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Update_Book.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_Book.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Update_Book.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Book.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Update_Book.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Update_Book.CheckedImage")));
            this.btn_Update_Book.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Update_Book.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update_Book.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Book.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Book.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btn_Update_Book.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Update_Book.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Book.Location = new System.Drawing.Point(7, 77);
            this.btn_Update_Book.Name = "btn_Update_Book";
            this.btn_Update_Book.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Update_Book.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Book.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Update_Book.OnHoverImage = null;
            this.btn_Update_Book.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Book.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Book.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Book.TabIndex = 4;
            this.btn_Update_Book.Text = "Sửa";
            this.btn_Update_Book.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update_Book.TextOffsetX = 24;
            this.btn_Update_Book.Click += new System.EventHandler(this.btn_Update_Book_Click);
            // 
            // btn_Add_New_Book
            // 
            this.btn_Add_New_Book.Animated = true;
            this.btn_Add_New_Book.AnimationHoverSpeed = 0.07F;
            this.btn_Add_New_Book.AnimationSpeed = 0.03F;
            this.btn_Add_New_Book.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Add_New_Book.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Book.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_New_Book.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Book.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Book.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_New_Book.CheckedImage")));
            this.btn_Add_New_Book.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_New_Book.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_New_Book.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_New_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Book.ForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Book.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_New_Book.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_New_Book.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_New_Book.Location = new System.Drawing.Point(7, 35);
            this.btn_Add_New_Book.Name = "btn_Add_New_Book";
            this.btn_Add_New_Book.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Add_New_Book.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Book.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Book.OnHoverImage = null;
            this.btn_Add_New_Book.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_New_Book.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_New_Book.Size = new System.Drawing.Size(108, 36);
            this.btn_Add_New_Book.TabIndex = 3;
            this.btn_Add_New_Book.Text = "Thêm ";
            this.btn_Add_New_Book.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_New_Book.TextOffsetX = 16;
            this.btn_Add_New_Book.Click += new System.EventHandler(this.btn_Add_New_Book_Click);
            // 
            // pnl_Book_Info
            // 
            this.pnl_Book_Info.Controls.Add(this.dgv_Book);
            this.pnl_Book_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Book_Info.Location = new System.Drawing.Point(268, 8);
            this.pnl_Book_Info.Name = "pnl_Book_Info";
            this.pnl_Book_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Book_Info.ShadowDecoration.Parent = this.pnl_Book_Info;
            this.pnl_Book_Info.Size = new System.Drawing.Size(572, 670);
            this.pnl_Book_Info.TabIndex = 7;
            // 
            // dgv_Book
            // 
            this.dgv_Book.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Book.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Book.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Book.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Book.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Book.EnableHeadersVisualStyles = false;
            this.dgv_Book.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Book.Location = new System.Drawing.Point(8, 8);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.ReadOnly = true;
            this.dgv_Book.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Book.RowHeadersVisible = false;
            this.dgv_Book.RowHeadersWidth = 51;
            this.dgv_Book.RowTemplate.Height = 28;
            this.dgv_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Book.Size = new System.Drawing.Size(556, 654);
            this.dgv_Book.TabIndex = 1;
            this.dgv_Book.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Book.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Book.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Book.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Book.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Book.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Book.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Book.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Book.ThemeStyle.ReadOnly = true;
            this.dgv_Book.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Book.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Book.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Book.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Book.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Book_CellClick);
            // 
            // Frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(848, 686);
            this.Controls.Add(this.pnl_Book_Info);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Book";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Book";
            this.Load += new System.EventHandler(this.Frm_Book_Load);
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Book_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sell_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Buy_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Book_Title;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Book;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Book;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_New_Book;
        private Guna.UI2.WinForms.Guna2Panel pnl_Book_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Book;
        private System.Windows.Forms.ComboBox cbo_Publishing;
        private System.Windows.Forms.ComboBox cbo_Book_Type;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUD_Quantity;
        private Guna.UI.WinForms.GunaLabel lbl_DoB;
        private Guna.UI.WinForms.GunaAdvenceButton btnDatlai;
        private Guna.UI.WinForms.GunaAdvenceButton btnThemnxb;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblNxb;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.Label lblGiamua;
        private System.Windows.Forms.Label lblTheloai;
    }
}