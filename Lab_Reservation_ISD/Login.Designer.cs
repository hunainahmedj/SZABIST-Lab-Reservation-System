namespace Lab_Reservation_ISD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
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
            this.btn_Login.Location = new System.Drawing.Point(318, 259);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(135, 50);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Id.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Id.HintText = "ID";
            this.txt_Id.isPassword = false;
            this.txt_Id.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_Id.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_Id.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_Id.LineThickness = 3;
            this.txt_Id.Location = new System.Drawing.Point(200, 129);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(370, 44);
            this.txt_Id.TabIndex = 3;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Pass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Pass.HintText = "Password";
            this.txt_Pass.isPassword = false;
            this.txt_Pass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_Pass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_Pass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_Pass.LineThickness = 3;
            this.txt_Pass.Location = new System.Drawing.Point(200, 181);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(370, 44);
            this.txt_Pass.TabIndex = 4;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Pass.OnValueChanged += new System.EventHandler(this.txt_Pass_OnValueChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Login);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(750, 406);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pass;
    }
}
