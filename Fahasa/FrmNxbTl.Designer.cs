
namespace Fahasa_Management_System
{
    partial class FrmNxbTl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNxbTl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtTentheloai = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoatheloai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnThemtheloai = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvTheloai = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Title = new Guna.UI.WinForms.GunaLabel();
            this.txtTennxb = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoanxb = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnThemnxb = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvNxb = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNxb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gunaLabel1);
            this.panel3.Controls.Add(this.txtTentheloai);
            this.panel3.Controls.Add(this.btnXoatheloai);
            this.panel3.Controls.Add(this.btnThemtheloai);
            this.panel3.Controls.Add(this.dgvTheloai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(417, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(415, 520);
            this.panel3.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(397, 48);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Quản lý thể loại";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTentheloai
            // 
            this.txtTentheloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTentheloai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTentheloai.DefaultText = "";
            this.txtTentheloai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTentheloai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTentheloai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTentheloai.DisabledState.Parent = this.txtTentheloai;
            this.txtTentheloai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTentheloai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTentheloai.FocusedState.Parent = this.txtTentheloai;
            this.txtTentheloai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentheloai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txtTentheloai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txtTentheloai.HoverState.Parent = this.txtTentheloai;
            this.txtTentheloai.Location = new System.Drawing.Point(24, 156);
            this.txtTentheloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentheloai.Name = "txtTentheloai";
            this.txtTentheloai.PasswordChar = '\0';
            this.txtTentheloai.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtTentheloai.PlaceholderText = "Tên thể loại:";
            this.txtTentheloai.SelectedText = "";
            this.txtTentheloai.ShadowDecoration.Parent = this.txtTentheloai;
            this.txtTentheloai.Size = new System.Drawing.Size(367, 36);
            this.txtTentheloai.TabIndex = 10;
            // 
            // btnXoatheloai
            // 
            this.btnXoatheloai.Animated = true;
            this.btnXoatheloai.AnimationHoverSpeed = 0.07F;
            this.btnXoatheloai.AnimationSpeed = 0.03F;
            this.btnXoatheloai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnXoatheloai.BorderColor = System.Drawing.Color.Black;
            this.btnXoatheloai.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnXoatheloai.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXoatheloai.CheckedForeColor = System.Drawing.Color.White;
            this.btnXoatheloai.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnXoatheloai.CheckedImage")));
            this.btnXoatheloai.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXoatheloai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoatheloai.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoatheloai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatheloai.ForeColor = System.Drawing.Color.White;
            this.btnXoatheloai.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btnXoatheloai.ImageSize = new System.Drawing.Size(32, 32);
            this.btnXoatheloai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoatheloai.Location = new System.Drawing.Point(221, 218);
            this.btnXoatheloai.Name = "btnXoatheloai";
            this.btnXoatheloai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnXoatheloai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoatheloai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoatheloai.OnHoverImage = null;
            this.btnXoatheloai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoatheloai.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoatheloai.Size = new System.Drawing.Size(171, 36);
            this.btnXoatheloai.TabIndex = 7;
            this.btnXoatheloai.Text = "Xóa";
            this.btnXoatheloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoatheloai.TextOffsetX = 24;
            this.btnXoatheloai.Click += new System.EventHandler(this.btnXoatheloai_Click);
            // 
            // btnThemtheloai
            // 
            this.btnThemtheloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemtheloai.Animated = true;
            this.btnThemtheloai.AnimationHoverSpeed = 0.07F;
            this.btnThemtheloai.AnimationSpeed = 0.03F;
            this.btnThemtheloai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnThemtheloai.BorderColor = System.Drawing.Color.Black;
            this.btnThemtheloai.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnThemtheloai.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnThemtheloai.CheckedForeColor = System.Drawing.Color.White;
            this.btnThemtheloai.CheckedImage = global::Fahasa_Management_System.Properties.Resources.print;
            this.btnThemtheloai.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnThemtheloai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemtheloai.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemtheloai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtheloai.ForeColor = System.Drawing.Color.White;
            this.btnThemtheloai.Image = global::Fahasa_Management_System.Properties.Resources.attendance;
            this.btnThemtheloai.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemtheloai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemtheloai.Location = new System.Drawing.Point(24, 217);
            this.btnThemtheloai.Name = "btnThemtheloai";
            this.btnThemtheloai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnThemtheloai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemtheloai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemtheloai.OnHoverImage = null;
            this.btnThemtheloai.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemtheloai.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemtheloai.Size = new System.Drawing.Size(171, 36);
            this.btnThemtheloai.TabIndex = 5;
            this.btnThemtheloai.Text = "Thêm";
            this.btnThemtheloai.Click += new System.EventHandler(this.btnThemtheloai_Click);
            // 
            // dgvTheloai
            // 
            this.dgvTheloai.AllowUserToAddRows = false;
            this.dgvTheloai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheloai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheloai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTheloai.Location = new System.Drawing.Point(8, 287);
            this.dgvTheloai.Name = "dgvTheloai";
            this.dgvTheloai.RowHeadersWidth = 51;
            this.dgvTheloai.RowTemplate.Height = 24;
            this.dgvTheloai.Size = new System.Drawing.Size(397, 223);
            this.dgvTheloai.TabIndex = 0;
            this.dgvTheloai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheloai_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_Title);
            this.panel2.Controls.Add(this.txtTennxb);
            this.panel2.Controls.Add(this.btnXoanxb);
            this.panel2.Controls.Add(this.btnThemnxb);
            this.panel2.Controls.Add(this.dgvNxb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(417, 520);
            this.panel2.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(8, 8);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(399, 48);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "Quản lý nhà xuất bản";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTennxb
            // 
            this.txtTennxb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTennxb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTennxb.DefaultText = "";
            this.txtTennxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTennxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTennxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennxb.DisabledState.Parent = this.txtTennxb;
            this.txtTennxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTennxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTennxb.FocusedState.Parent = this.txtTennxb;
            this.txtTennxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennxb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(67)))));
            this.txtTennxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.txtTennxb.HoverState.Parent = this.txtTennxb;
            this.txtTennxb.Location = new System.Drawing.Point(14, 156);
            this.txtTennxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTennxb.Name = "txtTennxb";
            this.txtTennxb.PasswordChar = '\0';
            this.txtTennxb.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtTennxb.PlaceholderText = "Tên nhà xuất bản:";
            this.txtTennxb.SelectedText = "";
            this.txtTennxb.ShadowDecoration.Parent = this.txtTennxb;
            this.txtTennxb.Size = new System.Drawing.Size(378, 36);
            this.txtTennxb.TabIndex = 9;
            // 
            // btnXoanxb
            // 
            this.btnXoanxb.Animated = true;
            this.btnXoanxb.AnimationHoverSpeed = 0.07F;
            this.btnXoanxb.AnimationSpeed = 0.03F;
            this.btnXoanxb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.btnXoanxb.BorderColor = System.Drawing.Color.Black;
            this.btnXoanxb.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnXoanxb.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnXoanxb.CheckedForeColor = System.Drawing.Color.White;
            this.btnXoanxb.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnXoanxb.CheckedImage")));
            this.btnXoanxb.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnXoanxb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoanxb.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoanxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanxb.ForeColor = System.Drawing.Color.White;
            this.btnXoanxb.Image = global::Fahasa_Management_System.Properties.Resources.delete;
            this.btnXoanxb.ImageSize = new System.Drawing.Size(32, 32);
            this.btnXoanxb.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoanxb.Location = new System.Drawing.Point(222, 218);
            this.btnXoanxb.Name = "btnXoanxb";
            this.btnXoanxb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnXoanxb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoanxb.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoanxb.OnHoverImage = null;
            this.btnXoanxb.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnXoanxb.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoanxb.Size = new System.Drawing.Size(171, 36);
            this.btnXoanxb.TabIndex = 6;
            this.btnXoanxb.Text = "Xóa";
            this.btnXoanxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoanxb.TextOffsetX = 24;
            this.btnXoanxb.Click += new System.EventHandler(this.btnXoanxb_Click);
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
            this.btnThemnxb.CheckedImage = global::Fahasa_Management_System.Properties.Resources.print;
            this.btnThemnxb.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnThemnxb.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemnxb.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemnxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnxb.ForeColor = System.Drawing.Color.White;
            this.btnThemnxb.Image = global::Fahasa_Management_System.Properties.Resources.attendance;
            this.btnThemnxb.ImageSize = new System.Drawing.Size(32, 32);
            this.btnThemnxb.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemnxb.Location = new System.Drawing.Point(14, 217);
            this.btnThemnxb.Name = "btnThemnxb";
            this.btnThemnxb.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(85)))));
            this.btnThemnxb.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemnxb.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemnxb.OnHoverImage = null;
            this.btnThemnxb.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnThemnxb.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemnxb.Size = new System.Drawing.Size(171, 36);
            this.btnThemnxb.TabIndex = 4;
            this.btnThemnxb.Text = "Thêm";
            this.btnThemnxb.Click += new System.EventHandler(this.btnThemnxb_Click);
            // 
            // dgvNxb
            // 
            this.dgvNxb.AllowUserToAddRows = false;
            this.dgvNxb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNxb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNxb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNxb.Location = new System.Drawing.Point(8, 287);
            this.dgvNxb.Name = "dgvNxb";
            this.dgvNxb.RowHeadersWidth = 51;
            this.dgvNxb.RowTemplate.Height = 24;
            this.dgvNxb.Size = new System.Drawing.Size(399, 223);
            this.dgvNxb.TabIndex = 0;
            this.dgvNxb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNxb_CellClick);
            // 
            // FrmNxbTl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(848, 536);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmNxbTl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "Quản lý Nxb-thể loại";
            this.Load += new System.EventHandler(this.FrmNxbTl_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheloai)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNxb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNxb;
        private System.Windows.Forms.DataGridView dgvTheloai;
        private Guna.UI.WinForms.GunaAdvenceButton btnThemnxb;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoatheloai;
        private Guna.UI.WinForms.GunaAdvenceButton btnThemtheloai;
        private Guna.UI.WinForms.GunaAdvenceButton btnXoanxb;
        private Guna.UI2.WinForms.Guna2TextBox txtTentheloai;
        private Guna.UI2.WinForms.Guna2TextBox txtTennxb;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lbl_Title;
    }
}