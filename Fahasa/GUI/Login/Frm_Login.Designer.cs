
namespace Fahasa_Management_System
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tog_ShowPasswork = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_Close = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // tog_ShowPasswork
            // 
            this.tog_ShowPasswork.Animated = true;
            this.tog_ShowPasswork.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.tog_ShowPasswork.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(85)))));
            this.tog_ShowPasswork.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tog_ShowPasswork.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tog_ShowPasswork.CheckedState.Parent = this.tog_ShowPasswork;
            this.tog_ShowPasswork.Location = new System.Drawing.Point(313, 252);
            this.tog_ShowPasswork.Name = "tog_ShowPasswork";
            this.tog_ShowPasswork.ShadowDecoration.Parent = this.tog_ShowPasswork;
            this.tog_ShowPasswork.Size = new System.Drawing.Size(35, 20);
            this.tog_ShowPasswork.TabIndex = 2;
            this.tog_ShowPasswork.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tog_ShowPasswork.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tog_ShowPasswork.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tog_ShowPasswork.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tog_ShowPasswork.UncheckedState.Parent = this.tog_ShowPasswork;
            this.tog_ShowPasswork.CheckedChanged += new System.EventHandler(this.tog_ShowPasswork_CheckedChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Fahasa_Management_System.Properties.Resources.Login_background;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-10, -16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(237, 437);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.BorderRadius = 4;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.DefaultText = "";
            this.txt_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.DisabledState.Parent = this.txt_Username;
            this.txt_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.FocusedState.Parent = this.txt_Username;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Username.HoverState.Parent = this.txt_Username;
            this.txt_Username.IconLeft = global::Fahasa_Management_System.Properties.Resources.user;
            this.txt_Username.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txt_Username.Location = new System.Drawing.Point(313, 134);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.SelectedText = "";
            this.txt_Username.ShadowDecoration.Parent = this.txt_Username;
            this.txt_Username.Size = new System.Drawing.Size(230, 36);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.TextOffset = new System.Drawing.Point(16, 0);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderRadius = 4;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.DefaultText = "";
            this.txt_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.DisabledState.Parent = this.txt_Password;
            this.txt_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txt_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.FocusedState.Parent = this.txt_Password;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Password.HoverState.Parent = this.txt_Password;
            this.txt_Password.IconLeft = global::Fahasa_Management_System.Properties.Resources.password;
            this.txt_Password.IconLeftSize = new System.Drawing.Size(24, 24);
            this.txt_Password.Location = new System.Drawing.Point(313, 198);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txt_Password.PlaceholderText = "Password";
            this.txt_Password.SelectedText = "";
            this.txt_Password.ShadowDecoration.Parent = this.txt_Password;
            this.txt_Password.Size = new System.Drawing.Size(230, 36);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.TextOffset = new System.Drawing.Point(16, 0);
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gunaLabel1.Location = new System.Drawing.Point(355, 253);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 17);
            this.gunaLabel1.TabIndex = 5;
            this.gunaLabel1.Text = "Hiện mật khẩu";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Animated = true;
            this.btn_Close.AnimationHoverSpeed = 0.07F;
            this.btn_Close.AnimationSpeed = 0.03F;
            this.btn_Close.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderColor = System.Drawing.Color.Black;
            this.btn_Close.CheckedBaseColor = System.Drawing.Color.IndianRed;
            this.btn_Close.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_Close.CheckedForeColor = System.Drawing.Color.White;
            this.btn_Close.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.CheckedImage")));
            this.btn_Close.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::Fahasa_Management_System.Properties.Resources.Close;
            this.btn_Close.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Close.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Close.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Close.Location = new System.Drawing.Point(595, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btn_Close.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Close.OnHoverImage = null;
            this.btn_Close.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_Close.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Close.Size = new System.Drawing.Size(38, 38);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Animated = true;
            this.btn_Login.AutoRoundedCorners = true;
            this.btn_Login.BorderRadius = 21;
            this.btn_Login.CheckedState.Parent = this.btn_Login;
            this.btn_Login.CustomImages.Parent = this.btn_Login;
            this.btn_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(221)))), ((int)(((byte)(211)))));
            this.btn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(182)))), ((int)(((byte)(197)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btn_Login.HoverState.Parent = this.btn_Login;
            this.btn_Login.Location = new System.Drawing.Point(313, 293);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.ShadowDecoration.Parent = this.btn_Login;
            this.btn_Login.Size = new System.Drawing.Size(230, 45);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(353, 57);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(136, 30);
            this.gunaLabel2.TabIndex = 8;
            this.gunaLabel2.Text = "USER LOGIN";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 379);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.tog_ShowPasswork);
            this.Controls.Add(this.guna2PictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahasa Management System";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tog_ShowPasswork;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Password;
        private Guna.UI2.WinForms.Guna2TextBox txt_Username;
        private Guna.UI.WinForms.GunaAdvenceButton btn_Close;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}