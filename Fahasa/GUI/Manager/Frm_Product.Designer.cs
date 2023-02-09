
namespace Fahasa_Management_System.GUI.Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Product));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Detail = new Guna.UI2.WinForms.Guna2Panel();
            this.gr_Information = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.lblGiamua = new System.Windows.Forms.Label();
            this.lblLoaisp = new System.Windows.Forms.Label();
            this.lblTensp = new System.Windows.Forms.Label();
            this.lbl_DoB = new Guna.UI.WinForms.GunaLabel();
            this.numUD_Quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_Sell_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Buy_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Product_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbo_Product_Type = new System.Windows.Forms.ComboBox();
            this.gr_Button = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bntDatlai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Delete_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Update_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Add_New_Product = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_Product_Info = new Guna.UI2.WinForms.Guna2Panel();
            this.dgv_Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Detail.SuspendLayout();
            this.gr_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).BeginInit();
            this.gr_Button.SuspendLayout();
            this.pnl_Product_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
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
            this.pnl_Detail.TabIndex = 7;
            // 
            // gr_Information
            // 
            this.gr_Information.AutoScroll = true;
            this.gr_Information.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Information.Controls.Add(this.lblSoluong);
            this.gr_Information.Controls.Add(this.lblGiaban);
            this.gr_Information.Controls.Add(this.lblGiamua);
            this.gr_Information.Controls.Add(this.lblLoaisp);
            this.gr_Information.Controls.Add(this.lblTensp);
            this.gr_Information.Controls.Add(this.lbl_DoB);
            this.gr_Information.Controls.Add(this.numUD_Quantity);
            this.gr_Information.Controls.Add(this.txt_Sell_Price);
            this.gr_Information.Controls.Add(this.txt_Buy_Price);
            this.gr_Information.Controls.Add(this.txt_Product_Name);
            this.gr_Information.Controls.Add(this.cbo_Product_Type);
            this.gr_Information.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Information.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gr_Information.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Information.ForeColor = System.Drawing.Color.White;
            this.gr_Information.Location = new System.Drawing.Point(8, 8);
            this.gr_Information.Name = "gr_Information";
            this.gr_Information.Padding = new System.Windows.Forms.Padding(4);
            this.gr_Information.ShadowDecoration.Parent = this.gr_Information;
            this.gr_Information.Size = new System.Drawing.Size(244, 383);
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
            this.lblSoluong.Location = new System.Drawing.Point(88, 319);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(0, 15);
            this.lblSoluong.TabIndex = 18;
            // 
            // lblGiaban
            // 
            this.lblGiaban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaban.ForeColor = System.Drawing.Color.Red;
            this.lblGiaban.Location = new System.Drawing.Point(7, 256);
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
            this.lblGiamua.Location = new System.Drawing.Point(7, 197);
            this.lblGiamua.Name = "lblGiamua";
            this.lblGiamua.Size = new System.Drawing.Size(0, 15);
            this.lblGiamua.TabIndex = 16;
            // 
            // lblLoaisp
            // 
            this.lblLoaisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoaisp.AutoSize = true;
            this.lblLoaisp.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaisp.ForeColor = System.Drawing.Color.Red;
            this.lblLoaisp.Location = new System.Drawing.Point(7, 139);
            this.lblLoaisp.Name = "lblLoaisp";
            this.lblLoaisp.Size = new System.Drawing.Size(0, 15);
            this.lblLoaisp.TabIndex = 15;
            // 
            // lblTensp
            // 
            this.lblTensp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTensp.AutoSize = true;
            this.lblTensp.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTensp.ForeColor = System.Drawing.Color.Red;
            this.lblTensp.Location = new System.Drawing.Point(7, 89);
            this.lblTensp.Name = "lblTensp";
            this.lblTensp.Size = new System.Drawing.Size(0, 15);
            this.lblTensp.TabIndex = 14;
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.lbl_DoB.Location = new System.Drawing.Point(3, 280);
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
            this.numUD_Quantity.Location = new System.Drawing.Point(91, 280);
            this.numUD_Quantity.Maximum = new decimal(new int[] {
            2000,
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
            this.txt_Sell_Price.Location = new System.Drawing.Point(7, 216);
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
            this.txt_Buy_Price.Location = new System.Drawing.Point(7, 158);
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
            // txt_Product_Name
            // 
            this.txt_Product_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Product_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Product_Name.DefaultText = "";
            this.txt_Product_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Product_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Product_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Product_Name.DisabledState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Product_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Product_Name.FocusedState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txt_Product_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txt_Product_Name.HoverState.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Location = new System.Drawing.Point(7, 50);
            this.txt_Product_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Product_Name.Name = "txt_Product_Name";
            this.txt_Product_Name.PasswordChar = '\0';
            this.txt_Product_Name.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt_Product_Name.PlaceholderText = "Tên Sản phẩm:";
            this.txt_Product_Name.SelectedText = "";
            this.txt_Product_Name.ShadowDecoration.Parent = this.txt_Product_Name;
            this.txt_Product_Name.Size = new System.Drawing.Size(230, 36);
            this.txt_Product_Name.TabIndex = 8;
            // 
            // cbo_Product_Type
            // 
            this.cbo_Product_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbo_Product_Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.cbo_Product_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbo_Product_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.cbo_Product_Type.ItemHeight = 25;
            this.cbo_Product_Type.Location = new System.Drawing.Point(7, 107);
            this.cbo_Product_Type.Name = "cbo_Product_Type";
            this.cbo_Product_Type.Size = new System.Drawing.Size(230, 33);
            this.cbo_Product_Type.Sorted = true;
            this.cbo_Product_Type.TabIndex = 1;
            this.cbo_Product_Type.Text = "Loại Sản phẩm:";
            // 
            // gr_Button
            // 
            this.gr_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.Controls.Add(this.bntDatlai);
            this.gr_Button.Controls.Add(this.btn_Delete_Product);
            this.gr_Button.Controls.Add(this.btn_Update_Product);
            this.gr_Button.Controls.Add(this.btn_Add_New_Product);
            this.gr_Button.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.gr_Button.CustomBorderThickness = new System.Windows.Forms.Padding(0, 28, 0, 0);
            this.gr_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gr_Button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_Button.ForeColor = System.Drawing.Color.White;
            this.gr_Button.Location = new System.Drawing.Point(8, 391);
            this.gr_Button.Name = "gr_Button";
            this.gr_Button.ShadowDecoration.Parent = this.gr_Button;
            this.gr_Button.Size = new System.Drawing.Size(244, 121);
            this.gr_Button.TabIndex = 4;
            this.gr_Button.Text = "Tác vụ";
            this.gr_Button.TextOffset = new System.Drawing.Point(0, -4);
            // 
            // bntDatlai
            // 
            this.bntDatlai.Animated = true;
            this.bntDatlai.AnimationHoverSpeed = 0.07F;
            this.bntDatlai.AnimationSpeed = 0.03F;
            this.bntDatlai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.bntDatlai.BorderColor = System.Drawing.Color.Black;
            this.bntDatlai.CheckedBaseColor = System.Drawing.Color.Gray;
            this.bntDatlai.CheckedBorderColor = System.Drawing.Color.Black;
            this.bntDatlai.CheckedForeColor = System.Drawing.Color.White;
            this.bntDatlai.CheckedImage = ((System.Drawing.Image)(resources.GetObject("bntDatlai.CheckedImage")));
            this.bntDatlai.CheckedLineColor = System.Drawing.Color.DimGray;
            this.bntDatlai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bntDatlai.FocusedColor = System.Drawing.Color.Empty;
            this.bntDatlai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDatlai.ForeColor = System.Drawing.Color.White;
            this.bntDatlai.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.bntDatlai.ImageSize = new System.Drawing.Size(32, 32);
            this.bntDatlai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bntDatlai.Location = new System.Drawing.Point(129, 35);
            this.bntDatlai.Name = "bntDatlai";
            this.bntDatlai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.bntDatlai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.bntDatlai.OnHoverForeColor = System.Drawing.Color.White;
            this.bntDatlai.OnHoverImage = null;
            this.bntDatlai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.bntDatlai.OnPressedColor = System.Drawing.Color.Black;
            this.bntDatlai.Size = new System.Drawing.Size(108, 36);
            this.bntDatlai.TabIndex = 6;
            this.bntDatlai.Text = "Đặt lại";
            this.bntDatlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.bntDatlai.TextOffsetX = 24;
            this.bntDatlai.Click += new System.EventHandler(this.bntDatlai_Click);
            // 
            // btn_Delete_Product
            // 
            this.btn_Delete_Product.Animated = true;
            this.btn_Delete_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Delete_Product.AnimationSpeed = 0.03F;
            this.btn_Delete_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Delete_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Delete_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Delete_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete_Product.CheckedImage")));
            this.btn_Delete_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Delete_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Delete_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Delete_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Delete_Product.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btn_Delete_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Delete_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.Location = new System.Drawing.Point(129, 77);
            this.btn_Delete_Product.Name = "btn_Delete_Product";
            this.btn_Delete_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Delete_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Delete_Product.OnHoverImage = null;
            this.btn_Delete_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Delete_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Delete_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Delete_Product.TabIndex = 5;
            this.btn_Delete_Product.Text = "Xóa";
            this.btn_Delete_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Delete_Product.TextOffsetX = 24;
            this.btn_Delete_Product.Click += new System.EventHandler(this.btn_Delete_Product_Click);
            // 
            // btn_Update_Product
            // 
            this.btn_Update_Product.Animated = true;
            this.btn_Update_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Update_Product.AnimationSpeed = 0.03F;
            this.btn_Update_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Update_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Update_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Update_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Update_Product.CheckedImage")));
            this.btn_Update_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Update_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Update_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Update_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Update_Product.Image = global::Fahasa_Management_System.Properties.Resources.update;
            this.btn_Update_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Update_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Product.Location = new System.Drawing.Point(7, 77);
            this.btn_Update_Product.Name = "btn_Update_Product";
            this.btn_Update_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Update_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Update_Product.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Update_Product.OnHoverImage = null;
            this.btn_Update_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Update_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Update_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Update_Product.TabIndex = 4;
            this.btn_Update_Product.Text = "Sửa";
            this.btn_Update_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Update_Product.TextOffsetX = 24;
            this.btn_Update_Product.Click += new System.EventHandler(this.btn_Update_Product_Click);
            // 
            // btn_Add_New_Product
            // 
            this.btn_Add_New_Product.Animated = true;
            this.btn_Add_New_Product.AnimationHoverSpeed = 0.07F;
            this.btn_Add_New_Product.AnimationSpeed = 0.03F;
            this.btn_Add_New_Product.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btn_Add_New_Product.BorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Product.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_Add_New_Product.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Product.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Product.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Add_New_Product.CheckedImage")));
            this.btn_Add_New_Product.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Add_New_Product.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add_New_Product.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add_New_Product.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Product.ForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Product.Image = global::Fahasa_Management_System.Properties.Resources.Insert;
            this.btn_Add_New_Product.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_Add_New_Product.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_New_Product.Location = new System.Drawing.Point(7, 35);
            this.btn_Add_New_Product.Name = "btn_Add_New_Product";
            this.btn_Add_New_Product.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btn_Add_New_Product.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Add_New_Product.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Add_New_Product.OnHoverImage = null;
            this.btn_Add_New_Product.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Add_New_Product.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add_New_Product.Size = new System.Drawing.Size(108, 36);
            this.btn_Add_New_Product.TabIndex = 3;
            this.btn_Add_New_Product.Text = "Thêm ";
            this.btn_Add_New_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Add_New_Product.TextOffsetX = 16;
            this.btn_Add_New_Product.Click += new System.EventHandler(this.btn_Add_New_Product_Click);
            // 
            // pnl_Product_Info
            // 
            this.pnl_Product_Info.Controls.Add(this.dgv_Product);
            this.pnl_Product_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Product_Info.Location = new System.Drawing.Point(268, 8);
            this.pnl_Product_Info.Name = "pnl_Product_Info";
            this.pnl_Product_Info.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Product_Info.ShadowDecoration.Parent = this.pnl_Product_Info;
            this.pnl_Product_Info.Size = new System.Drawing.Size(368, 520);
            this.pnl_Product_Info.TabIndex = 8;
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(85)))));
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
            this.dgv_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellClick);
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(644, 536);
            this.Controls.Add(this.pnl_Product_Info);
            this.Controls.Add(this.pnl_Detail);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Product";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Frm_Product";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            this.pnl_Detail.ResumeLayout(false);
            this.gr_Information.ResumeLayout(false);
            this.gr_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Quantity)).EndInit();
            this.gr_Button.ResumeLayout(false);
            this.pnl_Product_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Detail;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Information;
        private Guna.UI.WinForms.GunaLabel lbl_DoB;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUD_Quantity;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sell_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Buy_Price;
        private Guna.UI2.WinForms.Guna2TextBox txt_Product_Name;
        private System.Windows.Forms.ComboBox cbo_Product_Type;
        private Guna.UI2.WinForms.Guna2GroupBox gr_Button;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Delete_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Update_Product;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Add_New_Product;
        private Guna.UI2.WinForms.Guna2Panel pnl_Product_Info;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Product;
        private Guna.UI.WinForms.GunaAdvenceButton bntDatlai;
        private System.Windows.Forms.Label lblLoaisp;
        private System.Windows.Forms.Label lblTensp;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.Label lblGiamua;
    }
}