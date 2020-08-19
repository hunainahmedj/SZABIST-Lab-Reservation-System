namespace Lab_Reservation_ISD
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.header1 = new Lab_Reservation_ISD.Header();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_signup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Controls.Add(this.header1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 38);
            this.panel1.TabIndex = 10;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.header1.Location = new System.Drawing.Point(249, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(500, 38);
            this.header1.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_pass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_pass.HintText = "Password";
            this.txt_pass.isPassword = false;
            this.txt_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_pass.LineThickness = 3;
            this.txt_pass.Location = new System.Drawing.Point(190, 206);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(370, 44);
            this.txt_pass.TabIndex = 13;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass.OnValueChanged += new System.EventHandler(this.txt_pass_OnValueChanged);
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_email.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_email.HintText = "Email";
            this.txt_email.isPassword = false;
            this.txt_email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_email.LineThickness = 3;
            this.txt_email.Location = new System.Drawing.Point(190, 154);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(370, 44);
            this.txt_email.TabIndex = 12;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_signup
            // 
            this.btn_signup.ActiveBorderThickness = 1;
            this.btn_signup.ActiveCornerRadius = 3;
            this.btn_signup.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_signup.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_signup.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btn_signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_signup.BackgroundImage")));
            this.btn_signup.ButtonText = "Sign Up";
            this.btn_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_signup.IdleBorderThickness = 1;
            this.btn_signup.IdleCornerRadius = 3;
            this.btn_signup.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_signup.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_signup.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_signup.Location = new System.Drawing.Point(308, 333);
            this.btn_signup.Margin = new System.Windows.Forms.Padding(5);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(135, 50);
            this.btn_signup.TabIndex = 14;
            this.btn_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.ActiveBorderThickness = 1;
            this.btn_Login.ActiveCornerRadius = 3;
            this.btn_Login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_Login.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Login.IdleBorderThickness = 1;
            this.btn_Login.IdleCornerRadius = 3;
            this.btn_Login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Login.Location = new System.Drawing.Point(308, 284);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 50);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_Header.Location = new System.Drawing.Point(12, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(59, 22);
            this.lbl_Header.TabIndex = 6;
            this.lbl_Header.Text = "Login";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Header header1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_email;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_signup;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}