
namespace Fahasa_Management_System.GUI.Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Filter = new Guna.UI2.WinForms.Guna2Panel();
            this.cbo_Publishing = new System.Windows.Forms.ComboBox();
            this.cbo_Book_Type = new System.Windows.Forms.ComboBox();
            this.gr_Price = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type4_High = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type4_Low = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type3_High = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type3_Low = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type2_High = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type2_Low = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type1_High = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Price_Type1_Low = new Guna.UI.WinForms.GunaLabel();
            this.rdBtn_Price_Type4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdBtn_Price_Type2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdBtn_Price_Type3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdBtn_Price_Type1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.txt_Find_Book = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_Book_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Book = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Filter.SuspendLayout();
            this.gr_Price.SuspendLayout();
            this.pnl_Book_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.Controls.Add(this.cbo_Publishing);
            this.pnl_Filter.Controls.Add(this.cbo_Book_Type);
            this.pnl_Filter.Controls.Add(this.gr_Price);
            this.pnl_Filter.Controls.Add(this.txt_Find_Book);
            this.pnl_Filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Filter.Location = new System.Drawing.Point(8, 8);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Filter.ShadowDecoration.Parent = this.pnl_Filter;
            this.pnl_Filter.Size = new System.Drawing.Size(260, 520);
            this.pnl_Filter.TabIndex = 2;
            // 
            // cbo_Publishing
            // 
            this.cbo_Publishing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Publishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Publishing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Publishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Publishing.ItemHeight = 21;
            this.cbo_Publishing.Location = new System.Drawing.Point(11, 178);
            this.cbo_Publishing.Name = "cbo_Publishing";
            this.cbo_Publishing.Size = new System.Drawing.Size(230, 29);
            this.cbo_Publishing.Sorted = true;
            this.cbo_Publishing.TabIndex = 12;
            this.cbo_Publishing.Text = "Nhà XB";
            this.cbo_Publishing.SelectedValueChanged += new System.EventHandler(this.cbo_Publishing_SelectedValueChanged);
            // 
            // cbo_Book_Type
            // 
            this.cbo_Book_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Book_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Book_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Book_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Book_Type.ItemHeight = 21;
            this.cbo_Book_Type.Location = new System.Drawing.Point(11, 120);
            this.cbo_Book_Type.Name = "cbo_Book_Type";
            this.cbo_Book_Type.Size = new System.Drawing.Size(230, 29);
            this.cbo_Book_Type.Sorted = true;
            this.cbo_Book_Type.TabIndex = 4;
            this.cbo_Book_Type.Text = "Thể loại";
            this.cbo_Book_Type.SelectedValueChanged += new System.EventHandler(this.cbo_Book_Type_SelectedValueChanged);
            // 
            // gr_Price
            // 
            this.gr_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gr_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Price.Controls.Add(this.gunaLabel8);
            this.gr_Price.Controls.Add(this.lbl_Price_Type4_High);
            this.gr_Price.Controls.Add(this.lbl_Price_Type4_Low);
            this.gr_Price.Controls.Add(this.gunaLabel5);
            this.gr_Price.Controls.Add(this.lbl_Price_Type3_High);
            this.gr_Price.Controls.Add(this.lbl_Price_Type3_Low);
            this.gr_Price.Controls.Add(this.gunaLabel4);
            this.gr_Price.Controls.Add(this.lbl_Price_Type2_High);
            this.gr_Price.Controls.Add(this.lbl_Price_Type2_Low);
            this.gr_Price.Controls.Add(this.gunaLabel1);
            this.gr_Price.Controls.Add(this.lbl_Price_Type1_High);
            this.gr_Price.Controls.Add(this.lbl_Price_Type1_Low);
            this.gr_Price.Controls.Add(this.rdBtn_Price_Type4);
            this.gr_Price.Controls.Add(this.rdBtn_Price_Type2);
            this.gr_Price.Controls.Add(this.rdBtn_Price_Type3);
            this.gr_Price.Controls.Add(this.rdBtn_Price_Type1);
            this.gr_Price.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Price.ForeColor = System.Drawing.Color.White;
            this.gr_Price.Location = new System.Drawing.Point(11, 240);
            this.gr_Price.Name = "gr_Price";
            this.gr_Price.ShadowDecoration.Parent = this.gr_Price;
            this.gr_Price.Size = new System.Drawing.Size(238, 200);
            this.gr_Price.TabIndex = 2;
            this.gr_Price.Text = "Giá";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel8.Location = new System.Drawing.Point(115, 167);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(19, 20);
            this.gunaLabel8.TabIndex = 15;
            this.gunaLabel8.Text = "~";
            // 
            // lbl_Price_Type4_High
            // 
            this.lbl_Price_Type4_High.AutoSize = true;
            this.lbl_Price_Type4_High.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type4_High.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type4_High.Location = new System.Drawing.Point(148, 167);
            this.lbl_Price_Type4_High.Name = "lbl_Price_Type4_High";
            this.lbl_Price_Type4_High.Size = new System.Drawing.Size(69, 25);
            this.lbl_Price_Type4_High.TabIndex = 14;
            this.lbl_Price_Type4_High.Text = "Trở lên";
            // 
            // lbl_Price_Type4_Low
            // 
            this.lbl_Price_Type4_Low.AutoSize = true;
            this.lbl_Price_Type4_Low.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type4_Low.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type4_Low.Location = new System.Drawing.Point(48, 166);
            this.lbl_Price_Type4_Low.Name = "lbl_Price_Type4_Low";
            this.lbl_Price_Type4_Low.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type4_Low.TabIndex = 13;
            this.lbl_Price_Type4_Low.Text = "300000";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel5.Location = new System.Drawing.Point(115, 128);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(19, 20);
            this.gunaLabel5.TabIndex = 12;
            this.gunaLabel5.Text = "~";
            // 
            // lbl_Price_Type3_High
            // 
            this.lbl_Price_Type3_High.AutoSize = true;
            this.lbl_Price_Type3_High.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type3_High.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type3_High.Location = new System.Drawing.Point(148, 128);
            this.lbl_Price_Type3_High.Name = "lbl_Price_Type3_High";
            this.lbl_Price_Type3_High.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type3_High.TabIndex = 11;
            this.lbl_Price_Type3_High.Text = "300000";
            // 
            // lbl_Price_Type3_Low
            // 
            this.lbl_Price_Type3_Low.AutoSize = true;
            this.lbl_Price_Type3_Low.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type3_Low.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type3_Low.Location = new System.Drawing.Point(48, 127);
            this.lbl_Price_Type3_Low.Name = "lbl_Price_Type3_Low";
            this.lbl_Price_Type3_Low.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type3_Low.TabIndex = 10;
            this.lbl_Price_Type3_Low.Text = "200000";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel4.Location = new System.Drawing.Point(115, 90);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(19, 20);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "~";
            // 
            // lbl_Price_Type2_High
            // 
            this.lbl_Price_Type2_High.AutoSize = true;
            this.lbl_Price_Type2_High.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type2_High.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type2_High.Location = new System.Drawing.Point(148, 90);
            this.lbl_Price_Type2_High.Name = "lbl_Price_Type2_High";
            this.lbl_Price_Type2_High.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type2_High.TabIndex = 8;
            this.lbl_Price_Type2_High.Text = "200000";
            // 
            // lbl_Price_Type2_Low
            // 
            this.lbl_Price_Type2_Low.AutoSize = true;
            this.lbl_Price_Type2_Low.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type2_Low.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type2_Low.Location = new System.Drawing.Point(48, 89);
            this.lbl_Price_Type2_Low.Name = "lbl_Price_Type2_Low";
            this.lbl_Price_Type2_Low.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type2_Low.TabIndex = 7;
            this.lbl_Price_Type2_Low.Text = "100000";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.gunaLabel1.Location = new System.Drawing.Point(115, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(19, 20);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "~";
            // 
            // lbl_Price_Type1_High
            // 
            this.lbl_Price_Type1_High.AutoSize = true;
            this.lbl_Price_Type1_High.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type1_High.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type1_High.Location = new System.Drawing.Point(148, 55);
            this.lbl_Price_Type1_High.Name = "lbl_Price_Type1_High";
            this.lbl_Price_Type1_High.Size = new System.Drawing.Size(72, 25);
            this.lbl_Price_Type1_High.TabIndex = 5;
            this.lbl_Price_Type1_High.Text = "100000";
            // 
            // lbl_Price_Type1_Low
            // 
            this.lbl_Price_Type1_Low.AutoSize = true;
            this.lbl_Price_Type1_Low.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price_Type1_Low.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_Price_Type1_Low.Location = new System.Drawing.Point(69, 54);
            this.lbl_Price_Type1_Low.Name = "lbl_Price_Type1_Low";
            this.lbl_Price_Type1_Low.Size = new System.Drawing.Size(22, 25);
            this.lbl_Price_Type1_Low.TabIndex = 4;
            this.lbl_Price_Type1_Low.Text = "0";
            // 
            // rdBtn_Price_Type4
            // 
            this.rdBtn_Price_Type4.Animated = true;
            this.rdBtn_Price_Type4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type4.CheckedState.BorderThickness = 0;
            this.rdBtn_Price_Type4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBtn_Price_Type4.CheckedState.Parent = this.rdBtn_Price_Type4;
            this.rdBtn_Price_Type4.Location = new System.Drawing.Point(12, 166);
            this.rdBtn_Price_Type4.Name = "rdBtn_Price_Type4";
            this.rdBtn_Price_Type4.ShadowDecoration.Parent = this.rdBtn_Price_Type4;
            this.rdBtn_Price_Type4.Size = new System.Drawing.Size(20, 20);
            this.rdBtn_Price_Type4.TabIndex = 3;
            this.rdBtn_Price_Type4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBtn_Price_Type4.UncheckedState.BorderThickness = 2;
            this.rdBtn_Price_Type4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type4.UncheckedState.Parent = this.rdBtn_Price_Type4;
            this.rdBtn_Price_Type4.CheckedChanged += new System.EventHandler(this.rdBtn_Price_Type4_CheckedChanged);
            // 
            // rdBtn_Price_Type2
            // 
            this.rdBtn_Price_Type2.Animated = true;
            this.rdBtn_Price_Type2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type2.CheckedState.BorderThickness = 0;
            this.rdBtn_Price_Type2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBtn_Price_Type2.CheckedState.Parent = this.rdBtn_Price_Type2;
            this.rdBtn_Price_Type2.Location = new System.Drawing.Point(12, 90);
            this.rdBtn_Price_Type2.Name = "rdBtn_Price_Type2";
            this.rdBtn_Price_Type2.ShadowDecoration.Parent = this.rdBtn_Price_Type2;
            this.rdBtn_Price_Type2.Size = new System.Drawing.Size(20, 20);
            this.rdBtn_Price_Type2.TabIndex = 2;
            this.rdBtn_Price_Type2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBtn_Price_Type2.UncheckedState.BorderThickness = 2;
            this.rdBtn_Price_Type2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type2.UncheckedState.Parent = this.rdBtn_Price_Type2;
            this.rdBtn_Price_Type2.CheckedChanged += new System.EventHandler(this.rdBtn_Price_Type2_CheckedChanged);
            // 
            // rdBtn_Price_Type3
            // 
            this.rdBtn_Price_Type3.Animated = true;
            this.rdBtn_Price_Type3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type3.CheckedState.BorderThickness = 0;
            this.rdBtn_Price_Type3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBtn_Price_Type3.CheckedState.Parent = this.rdBtn_Price_Type3;
            this.rdBtn_Price_Type3.Location = new System.Drawing.Point(12, 127);
            this.rdBtn_Price_Type3.Name = "rdBtn_Price_Type3";
            this.rdBtn_Price_Type3.ShadowDecoration.Parent = this.rdBtn_Price_Type3;
            this.rdBtn_Price_Type3.Size = new System.Drawing.Size(20, 20);
            this.rdBtn_Price_Type3.TabIndex = 1;
            this.rdBtn_Price_Type3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBtn_Price_Type3.UncheckedState.BorderThickness = 2;
            this.rdBtn_Price_Type3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type3.UncheckedState.Parent = this.rdBtn_Price_Type3;
            this.rdBtn_Price_Type3.CheckedChanged += new System.EventHandler(this.rdBtn_Price_Type3_CheckedChanged);
            // 
            // rdBtn_Price_Type1
            // 
            this.rdBtn_Price_Type1.Animated = true;
            this.rdBtn_Price_Type1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type1.CheckedState.BorderThickness = 0;
            this.rdBtn_Price_Type1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.rdBtn_Price_Type1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBtn_Price_Type1.CheckedState.Parent = this.rdBtn_Price_Type1;
            this.rdBtn_Price_Type1.Location = new System.Drawing.Point(12, 55);
            this.rdBtn_Price_Type1.Name = "rdBtn_Price_Type1";
            this.rdBtn_Price_Type1.ShadowDecoration.Parent = this.rdBtn_Price_Type1;
            this.rdBtn_Price_Type1.Size = new System.Drawing.Size(20, 20);
            this.rdBtn_Price_Type1.TabIndex = 0;
            this.rdBtn_Price_Type1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBtn_Price_Type1.UncheckedState.BorderThickness = 2;
            this.rdBtn_Price_Type1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBtn_Price_Type1.UncheckedState.Parent = this.rdBtn_Price_Type1;
            this.rdBtn_Price_Type1.CheckedChanged += new System.EventHandler(this.rdBtn_Price_Type1_CheckedChanged);
            // 
            // txt_Find_Book
            // 
            this.txt_Find_Book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Find_Book.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Find_Book.DefaultText = "";
            this.txt_Find_Book.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Find_Book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Find_Book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find_Book.DisabledState.Parent = this.txt_Find_Book;
            this.txt_Find_Book.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find_Book.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Find_Book.FocusedState.Parent = this.txt_Find_Book;
            this.txt_Find_Book.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find_Book.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Find_Book.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Find_Book.HoverState.Parent = this.txt_Find_Book;
            this.txt_Find_Book.Location = new System.Drawing.Point(11, 62);
            this.txt_Find_Book.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Find_Book.Name = "txt_Find_Book";
            this.txt_Find_Book.PasswordChar = '\0';
            this.txt_Find_Book.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Find_Book.PlaceholderText = "Nhập từ khóa cần tìm";
            this.txt_Find_Book.SelectedText = "";
            this.txt_Find_Book.ShadowDecoration.Parent = this.txt_Find_Book;
            this.txt_Find_Book.Size = new System.Drawing.Size(238, 36);
            this.txt_Find_Book.TabIndex = 0;
            this.txt_Find_Book.TextChanged += new System.EventHandler(this.txt_Find_Book_TextChanged);
            this.txt_Find_Book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Find_KeyPress);
            // 
            // pnl_Book_Info
            // 
            this.pnl_Book_Info.Controls.Add(this.dgv_Book);
            this.pnl_Book_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Book_Info.Location = new System.Drawing.Point(268, 8);
            this.pnl_Book_Info.Name = "pnl_Book_Info";
            this.pnl_Book_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Book_Info.ShadowDecoration.Parent = this.pnl_Book_Info;
            this.pnl_Book_Info.Size = new System.Drawing.Size(368, 520);
            this.pnl_Book_Info.TabIndex = 3;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Book.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv_Book.Size = new System.Drawing.Size(352, 504);
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
            this.dgv_Book.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Book.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Book.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Book.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Book.ThemeStyle.ReadOnly = true;
            this.dgv_Book.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Book.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Book.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Book.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Book.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Book.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Frm_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(644, 536);
            this.Controls.Add(this.pnl_Book_Info);
            this.Controls.Add(this.pnl_Filter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Book";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Book";
            this.Load += new System.EventHandler(this.Frm_Book_Load);
            this.pnl_Filter.ResumeLayout(false);
            this.gr_Price.ResumeLayout(false);
            this.gr_Price.PerformLayout();
            this.pnl_Book_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnl_Filter;
        private Guna.UI2.WinForms.Guna2Panel pnl_Book_Info;
        private Guna.UI2.WinForms.Guna2TextBox txt_Find_Book;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Price;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type3;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type4_High;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type4_Low;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type3_High;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type3_Low;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type2_High;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type2_Low;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type1_High;
        private Guna.UI.WinForms.GunaLabel lbl_Price_Type1_Low;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Book;
        private System.Windows.Forms.ComboBox cbo_Book_Type;
        private System.Windows.Forms.ComboBox cbo_Publishing;
    }
}