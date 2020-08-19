namespace Lab_Reservation_ISD
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.btn_Register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_Id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_FName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_LName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Pass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
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
            this.btn_Register.Location = new System.Drawing.Point(314, 325);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(135, 50);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Register.Click += new System.EventHandler(this.btn_SignUp_Click);
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
            this.txt_Id.Location = new System.Drawing.Point(196, 7);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(370, 44);
            this.txt_Id.TabIndex = 7;
            this.txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_FName
            // 
            this.txt_FName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_FName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_FName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_FName.HintText = "First Name";
            this.txt_FName.isPassword = false;
            this.txt_FName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_FName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_FName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_FName.LineThickness = 3;
            this.txt_FName.Location = new System.Drawing.Point(196, 59);
            this.txt_FName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(370, 44);
            this.txt_FName.TabIndex = 8;
            this.txt_FName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_LName
            // 
            this.txt_LName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_LName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_LName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_LName.HintText = "Last Name";
            this.txt_LName.isPassword = false;
            this.txt_LName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_LName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_LName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_LName.LineThickness = 3;
            this.txt_LName.Location = new System.Drawing.Point(196, 111);
            this.txt_LName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(370, 44);
            this.txt_LName.TabIndex = 9;
            this.txt_LName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Email
            // 
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Email.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Email.HintText = "Email";
            this.txt_Email.isPassword = false;
            this.txt_Email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_Email.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_Email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_Email.LineThickness = 3;
            this.txt_Email.Location = new System.Drawing.Point(196, 163);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(370, 44);
            this.txt_Email.TabIndex = 10;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Email.OnValueChanged += new System.EventHandler(this.txt_Email_OnValueChanged);
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
            this.txt_Pass.Location = new System.Drawing.Point(196, 215);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(370, 44);
            this.txt_Pass.TabIndex = 11;
            this.txt_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Pass.OnValueChanged += new System.EventHandler(this.txt_Pass_OnValueChanged);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Phone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Phone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Phone.HintText = "Phone";
            this.txt_Phone.isPassword = false;
            this.txt_Phone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.txt_Phone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.txt_Phone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_Phone.LineThickness = 3;
            this.txt_Phone.Location = new System.Drawing.Point(196, 267);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(370, 44);
            this.txt_Phone.TabIndex = 12;
            this.txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Phone.OnValueChanged += new System.EventHandler(this.txt_Phone_OnValueChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btn_Register);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(750, 406);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Register;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_FName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_LName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Phone;
    }
}
