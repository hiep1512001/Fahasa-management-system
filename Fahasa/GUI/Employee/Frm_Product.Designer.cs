
namespace Fahasa_Management_System.GUI.Employee
{
    partial class Frm_Product
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
            this.pnl_Product = new Guna.UI2.WinForms.Guna2Panel();
            this.pnl_Product_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Filter = new Guna.UI2.WinForms.Guna2Panel();
            this.cbo_Product_Type = new System.Windows.Forms.ComboBox();
            this.gr_Product_Price = new Guna.UI2.WinForms.Guna2GroupBox();
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
            this.txt_Find_Product = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_Product.SuspendLayout();
            this.pnl_Product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.pnl_Filter.SuspendLayout();
            this.gr_Product_Price.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Product
            // 
            this.pnl_Product.Controls.Add(this.pnl_Product_Info);
            this.pnl_Product.Controls.Add(this.pnl_Filter);
            this.pnl_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product.Location = new System.Drawing.Point(8, 8);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.ShadowDecoration.Parent = this.pnl_Product;
            this.pnl_Product.Size = new System.Drawing.Size(628, 520);
            this.pnl_Product.TabIndex = 0;
            // 
            // pnl_Product_Info
            // 
            this.pnl_Product_Info.Controls.Add(this.dgv_Product);
            this.pnl_Product_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product_Info.Location = new System.Drawing.Point(260, 0);
            this.pnl_Product_Info.Name = "pnl_Product_Info";
            this.pnl_Product_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Product_Info.ShadowDecoration.Parent = this.pnl_Product_Info;
            this.pnl_Product_Info.Size = new System.Drawing.Size(368, 520);
            this.pnl_Product_Info.TabIndex = 4;
            // 
            // dgv_Product
            // 
            this.dgv_Product.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Product.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Product.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.EnableHeadersVisualStyles = false;
            this.dgv_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.Location = new System.Drawing.Point(8, 8);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Product.RowHeadersVisible = false;
            this.dgv_Product.RowHeadersWidth = 51;
            this.dgv_Product.RowTemplate.Height = 28;
            this.dgv_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Product.Size = new System.Drawing.Size(352, 504);
            this.dgv_Product.TabIndex = 1;
            this.dgv_Product.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Product.ThemeStyle.HeaderStyle.Height = 32;
            this.dgv_Product.ThemeStyle.ReadOnly = true;
            this.dgv_Product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.dgv_Product.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.Controls.Add(this.cbo_Product_Type);
            this.pnl_Filter.Controls.Add(this.gr_Product_Price);
            this.pnl_Filter.Controls.Add(this.txt_Find_Product);
            this.pnl_Filter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Filter.Location = new System.Drawing.Point(0, 0);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Filter.ShadowDecoration.Parent = this.pnl_Filter;
            this.pnl_Filter.Size = new System.Drawing.Size(260, 520);
            this.pnl_Filter.TabIndex = 3;
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Product_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Product_Type.ItemHeight = 25;
            this.cbo_Product_Type.Location = new System.Drawing.Point(11, 155);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.Size = new System.Drawing.Size(230, 33);
            this.cbo_Product_Type.Sorted = true;
            this.cbo_Product_Type.TabIndex = 5;
            this.cbo_Product_Type.Text = "Loại Sản phẩm:";
            this.cbo_Product_Type.SelectedIndexChanged += new System.EventHandler(this.cbo_Product_Type_SelectedIndexChanged);
            // 
            // gr_Product_Price
            // 
            this.gr_Product_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gr_Product_Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Product_Price.Controls.Add(this.gunaLabel8);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type4_High);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type4_Low);
            this.gr_Product_Price.Controls.Add(this.gunaLabel5);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type3_High);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type3_Low);
            this.gr_Product_Price.Controls.Add(this.gunaLabel4);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type2_High);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type2_Low);
            this.gr_Product_Price.Controls.Add(this.gunaLabel1);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type1_High);
            this.gr_Product_Price.Controls.Add(this.lbl_Price_Type1_Low);
            this.gr_Product_Price.Controls.Add(this.rdBtn_Price_Type4);
            this.gr_Product_Price.Controls.Add(this.rdBtn_Price_Type2);
            this.gr_Product_Price.Controls.Add(this.rdBtn_Price_Type3);
            this.gr_Product_Price.Controls.Add(this.rdBtn_Price_Type1);
            this.gr_Product_Price.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Product_Price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Product_Price.ForeColor = System.Drawing.Color.White;
            this.gr_Product_Price.Location = new System.Drawing.Point(11, 241);
            this.gr_Product_Price.Name = "gr_Product_Price";
            this.gr_Product_Price.ShadowDecoration.Parent = this.gr_Product_Price;
            this.gr_Product_Price.Size = new System.Drawing.Size(238, 200);
            this.gr_Product_Price.TabIndex = 4;
            this.gr_Product_Price.Text = "Giá";
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
            // txt_Find_Product
            // 
            this.txt_Find_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Find_Product.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Find_Product.DefaultText = "";
            this.txt_Find_Product.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Find_Product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Find_Product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find_Product.DisabledState.Parent = this.txt_Find_Product;
            this.txt_Find_Product.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Find_Product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Find_Product.FocusedState.Parent = this.txt_Find_Product;
            this.txt_Find_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Find_Product.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Find_Product.HoverState.Parent = this.txt_Find_Product;
            this.txt_Find_Product.Location = new System.Drawing.Point(11, 63);
            this.txt_Find_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Find_Product.Name = "txt_Find_Product";
            this.txt_Find_Product.PasswordChar = '\0';
            this.txt_Find_Product.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Find_Product.PlaceholderText = "Nhập từ khóa cần tìm";
            this.txt_Find_Product.SelectedText = "";
            this.txt_Find_Product.ShadowDecoration.Parent = this.txt_Find_Product;
            this.txt_Find_Product.Size = new System.Drawing.Size(238, 36);
            this.txt_Find_Product.TabIndex = 0;
            this.txt_Find_Product.TextChanged += new System.EventHandler(this.txt_Find_Product_TextChanged);
            this.txt_Find_Product.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Find_Product_KeyPress);
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(644, 536);
            this.Controls.Add(this.pnl_Product);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Product";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Product";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            this.pnl_Product.ResumeLayout(false);
            this.pnl_Product_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.pnl_Filter.ResumeLayout(false);
            this.gr_Product_Price.ResumeLayout(false);
            this.gr_Product_Price.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Product;
        private Guna.UI2.WinForms.Guna2Panel pnl_Filter;
        private Guna.UI2.WinForms.Guna2TextBox txt_Find_Product;
        private Guna.UI2.WinForms.Guna2Panel pnl_Product_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Product;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Product_Price;
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
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdBtn_Price_Type1;
        private System.Windows.Forms.ComboBox cbo_Product_Type;
    }
}