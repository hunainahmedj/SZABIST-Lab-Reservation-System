namespace Lab_Reservation_ISD
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_EntryTabBtns = new System.Windows.Forms.Panel();
            this.tBtn_Register = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tBtn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.p_EntryControl = new System.Windows.Forms.Panel();
            this.p_EntryHeader = new System.Windows.Forms.Panel();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header1 = new Lab_Reservation_ISD.Header();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.p_EntryTabBtns.SuspendLayout();
            this.p_EntryHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // p_EntryTabBtns
            // 
            this.p_EntryTabBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.p_EntryTabBtns.Controls.Add(this.tBtn_Register);
            this.p_EntryTabBtns.Controls.Add(this.tBtn_Login);
            this.p_EntryTabBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_EntryTabBtns.Location = new System.Drawing.Point(0, 407);
            this.p_EntryTabBtns.Margin = new System.Windows.Forms.Padding(2);
            this.p_EntryTabBtns.Name = "p_EntryTabBtns";
            this.p_EntryTabBtns.Size = new System.Drawing.Size(750, 81);
            this.p_EntryTabBtns.TabIndex = 0;
            // 
            // tBtn_Register
            // 
            this.tBtn_Register.ActiveBorderThickness = 1;
            this.tBtn_Register.ActiveCornerRadius = 3;
            this.tBtn_Register.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.tBtn_Register.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Register.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.tBtn_Register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tBtn_Register.BackgroundImage")));
            this.tBtn_Register.ButtonText = "New User";
            this.tBtn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBtn_Register.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Register.IdleBorderThickness = 1;
            this.tBtn_Register.IdleCornerRadius = 3;
            this.tBtn_Register.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tBtn_Register.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Register.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Register.Location = new System.Drawing.Point(443, 6);
            this.tBtn_Register.Margin = new System.Windows.Forms.Padding(4);
            this.tBtn_Register.Name = "tBtn_Register";
            this.tBtn_Register.Size = new System.Drawing.Size(135, 50);
            this.tBtn_Register.TabIndex = 1;
            this.tBtn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tBtn_Register.Click += new System.EventHandler(this.tBtn_Register_Click);
            // 
            // tBtn_Login
            // 
            this.tBtn_Login.ActiveBorderThickness = 1;
            this.tBtn_Login.ActiveCornerRadius = 3;
            this.tBtn_Login.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.tBtn_Login.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.tBtn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tBtn_Login.BackgroundImage")));
            this.tBtn_Login.ButtonText = "Sign In";
            this.tBtn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tBtn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBtn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Login.IdleBorderThickness = 1;
            this.tBtn_Login.IdleCornerRadius = 3;
            this.tBtn_Login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tBtn_Login.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tBtn_Login.Location = new System.Drawing.Point(149, 6);
            this.tBtn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.tBtn_Login.Name = "tBtn_Login";
            this.tBtn_Login.Size = new System.Drawing.Size(135, 50);
            this.tBtn_Login.TabIndex = 0;
            this.tBtn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tBtn_Login.Click += new System.EventHandler(this.tbtn_login_click);
            // 
            // p_EntryControl
            // 
            this.p_EntryControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.p_EntryControl.Location = new System.Drawing.Point(0, 34);
            this.p_EntryControl.Margin = new System.Windows.Forms.Padding(2);
            this.p_EntryControl.Name = "p_EntryControl";
            this.p_EntryControl.Size = new System.Drawing.Size(750, 373);
            this.p_EntryControl.TabIndex = 1;
            // 
            // p_EntryHeader
            // 
            this.p_EntryHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.p_EntryHeader.Controls.Add(this.lbl_Header);
            this.p_EntryHeader.Controls.Add(this.header1);
            this.p_EntryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_EntryHeader.Location = new System.Drawing.Point(0, 0);
            this.p_EntryHeader.Margin = new System.Windows.Forms.Padding(2);
            this.p_EntryHeader.Name = "p_EntryHeader";
            this.p_EntryHeader.Size = new System.Drawing.Size(750, 38);
            this.p_EntryHeader.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_Header.Location = new System.Drawing.Point(12, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(59, 22);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Login";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.header1.Location = new System.Drawing.Point(248, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(500, 38);
            this.header1.TabIndex = 0;
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
            this.bunifuDragControl2.TargetControl = this.p_EntryHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.p_EntryHeader);
            this.Controls.Add(this.p_EntryControl);
            this.Controls.Add(this.p_EntryTabBtns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Entry";
            this.Text = "Entry";
            this.p_EntryTabBtns.ResumeLayout(false);
            this.p_EntryHeader.ResumeLayout(false);
            this.p_EntryHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel p_EntryControl;
        private System.Windows.Forms.Panel p_EntryHeader;
        private System.Windows.Forms.Panel p_EntryTabBtns;
        private Bunifu.Framework.UI.BunifuThinButton2 tBtn_Register;
        private Bunifu.Framework.UI.BunifuThinButton2 tBtn_Login;
        private Header header1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}