namespace Lab_Reservation_ISD
{
    partial class SettingsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.txt_ChangeEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.card_ProfileDetails = new Bunifu.Framework.UI.BunifuCards();
            this.btn_EmailConfrim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbl_ChangeEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_ChangePassConfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_PassConfrim = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_ChangePass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_ChangePass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card_ProfileDetails.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ChangeEmail
            // 
            this.txt_ChangeEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChangeEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangeEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangeEmail.HintText = "New Email";
            this.txt_ChangeEmail.isPassword = false;
            this.txt_ChangeEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_ChangeEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_ChangeEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_ChangeEmail.LineThickness = 3;
            this.txt_ChangeEmail.Location = new System.Drawing.Point(35, 94);
            this.txt_ChangeEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChangeEmail.Name = "txt_ChangeEmail";
            this.txt_ChangeEmail.Size = new System.Drawing.Size(278, 36);
            this.txt_ChangeEmail.TabIndex = 5;
            this.txt_ChangeEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ChangeEmail.OnValueChanged += new System.EventHandler(this.txt_ChangeEmail_OnValueChanged);
            // 
            // card_ProfileDetails
            // 
            this.card_ProfileDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.card_ProfileDetails.BorderRadius = 5;
            this.card_ProfileDetails.BottomSahddow = true;
            this.card_ProfileDetails.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.card_ProfileDetails.Controls.Add(this.btn_EmailConfrim);
            this.card_ProfileDetails.Controls.Add(this.txt_ChangeEmail);
            this.card_ProfileDetails.Controls.Add(this.lbl_ChangeEmail);
            this.card_ProfileDetails.LeftSahddow = false;
            this.card_ProfileDetails.Location = new System.Drawing.Point(446, 176);
            this.card_ProfileDetails.Name = "card_ProfileDetails";
            this.card_ProfileDetails.RightSahddow = true;
            this.card_ProfileDetails.ShadowDepth = 20;
            this.card_ProfileDetails.Size = new System.Drawing.Size(341, 247);
            this.card_ProfileDetails.TabIndex = 7;
            // 
            // btn_EmailConfrim
            // 
            this.btn_EmailConfrim.ActiveBorderThickness = 1;
            this.btn_EmailConfrim.ActiveCornerRadius = 3;
            this.btn_EmailConfrim.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_EmailConfrim.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_EmailConfrim.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_EmailConfrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btn_EmailConfrim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EmailConfrim.BackgroundImage")));
            this.btn_EmailConfrim.ButtonText = "Confirm";
            this.btn_EmailConfrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EmailConfrim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmailConfrim.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_EmailConfrim.IdleBorderThickness = 1;
            this.btn_EmailConfrim.IdleCornerRadius = 3;
            this.btn_EmailConfrim.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_EmailConfrim.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_EmailConfrim.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_EmailConfrim.Location = new System.Drawing.Point(106, 170);
            this.btn_EmailConfrim.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EmailConfrim.Name = "btn_EmailConfrim";
            this.btn_EmailConfrim.Size = new System.Drawing.Size(135, 50);
            this.btn_EmailConfrim.TabIndex = 8;
            this.btn_EmailConfrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EmailConfrim.Click += new System.EventHandler(this.btn_EmailConfrim_Click);
            // 
            // lbl_ChangeEmail
            // 
            this.lbl_ChangeEmail.AutoSize = true;
            this.lbl_ChangeEmail.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ChangeEmail.Location = new System.Drawing.Point(15, 23);
            this.lbl_ChangeEmail.Name = "lbl_ChangeEmail";
            this.lbl_ChangeEmail.Size = new System.Drawing.Size(143, 22);
            this.lbl_ChangeEmail.TabIndex = 2;
            this.lbl_ChangeEmail.Text = "Change Email:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.bunifuCards1.Controls.Add(this.txt_ChangePassConfirm);
            this.bunifuCards1.Controls.Add(this.btn_PassConfrim);
            this.bunifuCards1.Controls.Add(this.txt_ChangePass);
            this.bunifuCards1.Controls.Add(this.lbl_ChangePass);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(60, 176);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(341, 247);
            this.bunifuCards1.TabIndex = 8;
            // 
            // txt_ChangePassConfirm
            // 
            this.txt_ChangePassConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChangePassConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ChangePassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangePassConfirm.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangePassConfirm.HintText = "Confirm Password";
            this.txt_ChangePassConfirm.isPassword = false;
            this.txt_ChangePassConfirm.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_ChangePassConfirm.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_ChangePassConfirm.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_ChangePassConfirm.LineThickness = 3;
            this.txt_ChangePassConfirm.Location = new System.Drawing.Point(35, 109);
            this.txt_ChangePassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChangePassConfirm.Name = "txt_ChangePassConfirm";
            this.txt_ChangePassConfirm.Size = new System.Drawing.Size(278, 36);
            this.txt_ChangePassConfirm.TabIndex = 7;
            this.txt_ChangePassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ChangePassConfirm.OnValueChanged += new System.EventHandler(this.txt_ChangePassConfirm_OnValueChanged);
            // 
            // btn_PassConfrim
            // 
            this.btn_PassConfrim.ActiveBorderThickness = 1;
            this.btn_PassConfrim.ActiveCornerRadius = 3;
            this.btn_PassConfrim.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_PassConfrim.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_PassConfrim.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_PassConfrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.btn_PassConfrim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PassConfrim.BackgroundImage")));
            this.btn_PassConfrim.ButtonText = "Confirm";
            this.btn_PassConfrim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PassConfrim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PassConfrim.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_PassConfrim.IdleBorderThickness = 1;
            this.btn_PassConfrim.IdleCornerRadius = 3;
            this.btn_PassConfrim.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_PassConfrim.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_PassConfrim.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_PassConfrim.Location = new System.Drawing.Point(104, 170);
            this.btn_PassConfrim.Margin = new System.Windows.Forms.Padding(5);
            this.btn_PassConfrim.Name = "btn_PassConfrim";
            this.btn_PassConfrim.Size = new System.Drawing.Size(135, 50);
            this.btn_PassConfrim.TabIndex = 6;
            this.btn_PassConfrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PassConfrim.Click += new System.EventHandler(this.btn_PassConfrim_Click);
            // 
            // txt_ChangePass
            // 
            this.txt_ChangePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ChangePass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangePass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ChangePass.HintText = "New Password";
            this.txt_ChangePass.isPassword = false;
            this.txt_ChangePass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_ChangePass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_ChangePass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_ChangePass.LineThickness = 3;
            this.txt_ChangePass.Location = new System.Drawing.Point(35, 65);
            this.txt_ChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChangePass.Name = "txt_ChangePass";
            this.txt_ChangePass.Size = new System.Drawing.Size(278, 36);
            this.txt_ChangePass.TabIndex = 5;
            this.txt_ChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ChangePass.OnValueChanged += new System.EventHandler(this.txt_ChangePass_OnValueChanged);
            // 
            // lbl_ChangePass
            // 
            this.lbl_ChangePass.AutoSize = true;
            this.lbl_ChangePass.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ChangePass.Location = new System.Drawing.Point(15, 23);
            this.lbl_ChangePass.Name = "lbl_ChangePass";
            this.lbl_ChangePass.Size = new System.Drawing.Size(182, 22);
            this.lbl_ChangePass.TabIndex = 2;
            this.lbl_ChangePass.Text = "Change Password:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.card_ProfileDetails);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(854, 562);
            this.card_ProfileDetails.ResumeLayout(false);
            this.card_ProfileDetails.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ChangeEmail;
        private Bunifu.Framework.UI.BunifuCards card_ProfileDetails;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_EmailConfrim;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ChangeEmail;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ChangePassConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_PassConfrim;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ChangePass;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ChangePass;
    }
}
