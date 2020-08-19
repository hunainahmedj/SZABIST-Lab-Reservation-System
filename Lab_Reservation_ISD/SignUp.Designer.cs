namespace Lab_Reservation_ISD
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Entry_Header = new System.Windows.Forms.Panel();
            this.header1 = new Lab_Reservation_ISD.Header();
            this.txt_c_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Entry_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Entry_Header
            // 
            this.Entry_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Entry_Header.Controls.Add(this.lbl_Header);
            this.Entry_Header.Controls.Add(this.header1);
            this.Entry_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entry_Header.Location = new System.Drawing.Point(0, 0);
            this.Entry_Header.Name = "Entry_Header";
            this.Entry_Header.Size = new System.Drawing.Size(750, 38);
            this.Entry_Header.TabIndex = 18;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.header1.Location = new System.Drawing.Point(249, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(500, 38);
            this.header1.TabIndex = 5;
            // 
            // txt_c_pass
            // 
            this.txt_c_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_c_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_c_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_c_pass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_c_pass.HintText = "Confirm Password";
            this.txt_c_pass.isPassword = false;
            this.txt_c_pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_c_pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_c_pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_c_pass.LineThickness = 3;
            this.txt_c_pass.Location = new System.Drawing.Point(191, 288);
            this.txt_c_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_c_pass.Name = "txt_c_pass";
            this.txt_c_pass.Size = new System.Drawing.Size(370, 44);
            this.txt_c_pass.TabIndex = 19;
            this.txt_c_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_c_pass.OnValueChanged += new System.EventHandler(this.txt_c_pass_OnValueChanged);
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
            this.txt_pass.Location = new System.Drawing.Point(191, 236);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(370, 44);
            this.txt_pass.TabIndex = 18;
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
            this.txt_email.Location = new System.Drawing.Point(191, 184);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(370, 44);
            this.txt_email.TabIndex = 17;
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_email.OnValueChanged += new System.EventHandler(this.txt_email_OnValueChanged);
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_name.HintText = "First Name";
            this.txt_name.isPassword = false;
            this.txt_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_name.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_name.LineThickness = 3;
            this.txt_name.Location = new System.Drawing.Point(191, 132);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(370, 44);
            this.txt_name.TabIndex = 15;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Register
            // 
            this.btn_Register.ActiveBorderThickness = 1;
            this.btn_Register.ActiveCornerRadius = 3;
            this.btn_Register.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.btn_Register.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Register.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.BackgroundImage")));
            this.btn_Register.ButtonText = "Register";
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_Register.IdleBorderThickness = 1;
            this.btn_Register.IdleCornerRadius = 3;
            this.btn_Register.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.btn_Register.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Register.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Register.Location = new System.Drawing.Point(309, 373);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(135, 50);
            this.btn_Register.TabIndex = 13;
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Register.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 3;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 3;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(309, 424);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(135, 50);
            this.bunifuThinButton21.TabIndex = 20;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_Header.Location = new System.Drawing.Point(12, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(77, 22);
            this.lbl_Header.TabIndex = 6;
            this.lbl_Header.Text = "Sign Up";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Entry_Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.header1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.txt_c_pass);
            this.Controls.Add(this.Entry_Header);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Entry_Header.ResumeLayout(false);
            this.Entry_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Entry_Header;
        private Header header1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_c_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_email;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Register;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}