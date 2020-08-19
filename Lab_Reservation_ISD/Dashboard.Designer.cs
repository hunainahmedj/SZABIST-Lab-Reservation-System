namespace Lab_Reservation_ISD
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_DashNav = new System.Windows.Forms.Panel();
            this.p_DashHeader = new System.Windows.Forms.Panel();
            this.lbl_Header = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.header1 = new Lab_Reservation_ISD.Header();
            this.p_DashControl = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.nBtn_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nBtn_LogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nBtn_Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nBtn_Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nBtn_Reserve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nBtn_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.p_DashNav.SuspendLayout();
            this.p_DashHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // p_DashNav
            // 
            this.p_DashNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.p_DashNav.Controls.Add(this.bunifuImageButton1);
            this.p_DashNav.Controls.Add(this.nBtn_Exit);
            this.p_DashNav.Controls.Add(this.nBtn_LogOut);
            this.p_DashNav.Controls.Add(this.nBtn_Settings);
            this.p_DashNav.Controls.Add(this.nBtn_Cancel);
            this.p_DashNav.Controls.Add(this.nBtn_Reserve);
            this.p_DashNav.Controls.Add(this.nBtn_Home);
            this.p_DashNav.Location = new System.Drawing.Point(0, 38);
            this.p_DashNav.Margin = new System.Windows.Forms.Padding(2);
            this.p_DashNav.Name = "p_DashNav";
            this.p_DashNav.Size = new System.Drawing.Size(152, 562);
            this.p_DashNav.TabIndex = 0;
            // 
            // p_DashHeader
            // 
            this.p_DashHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.p_DashHeader.Controls.Add(this.lbl_Header);
            this.p_DashHeader.Controls.Add(this.header1);
            this.p_DashHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_DashHeader.Location = new System.Drawing.Point(0, 0);
            this.p_DashHeader.Margin = new System.Windows.Forms.Padding(2);
            this.p_DashHeader.Name = "p_DashHeader";
            this.p_DashHeader.Size = new System.Drawing.Size(1000, 38);
            this.p_DashHeader.TabIndex = 1;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_Header.Location = new System.Drawing.Point(6, 8);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(113, 22);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Dashboard";
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.header1.Location = new System.Drawing.Point(500, 0);
            this.header1.Margin = new System.Windows.Forms.Padding(4);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(500, 38);
            this.header1.TabIndex = 0;
            // 
            // p_DashControl
            // 
            this.p_DashControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.p_DashControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_DashControl.Location = new System.Drawing.Point(146, 38);
            this.p_DashControl.Margin = new System.Windows.Forms.Padding(2);
            this.p_DashControl.Name = "p_DashControl";
            this.p_DashControl.Size = new System.Drawing.Size(854, 562);
            this.p_DashControl.TabIndex = 2;
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
            this.bunifuDragControl2.TargetControl = this.p_DashHeader;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(3, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(140, 106);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // nBtn_Exit
            // 
            this.nBtn_Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_Exit.BorderRadius = 0;
            this.nBtn_Exit.ButtonText = "Exit";
            this.nBtn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_Exit.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_Exit.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.open_exit_door;
            this.nBtn_Exit.Iconimage_right = null;
            this.nBtn_Exit.Iconimage_right_Selected = null;
            this.nBtn_Exit.Iconimage_Selected = null;
            this.nBtn_Exit.IconMarginLeft = 0;
            this.nBtn_Exit.IconMarginRight = 0;
            this.nBtn_Exit.IconRightVisible = true;
            this.nBtn_Exit.IconRightZoom = 0D;
            this.nBtn_Exit.IconVisible = true;
            this.nBtn_Exit.IconZoom = 50D;
            this.nBtn_Exit.IsTab = true;
            this.nBtn_Exit.Location = new System.Drawing.Point(1, 476);
            this.nBtn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_Exit.Name = "nBtn_Exit";
            this.nBtn_Exit.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.nBtn_Exit.selected = false;
            this.nBtn_Exit.Size = new System.Drawing.Size(142, 48);
            this.nBtn_Exit.TabIndex = 5;
            this.nBtn_Exit.Text = "Exit";
            this.nBtn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_Exit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Exit.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_Exit.Click += new System.EventHandler(this.nBtn_Exit_Click);
            // 
            // nBtn_LogOut
            // 
            this.nBtn_LogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_LogOut.BorderRadius = 0;
            this.nBtn_LogOut.ButtonText = "Logout";
            this.nBtn_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_LogOut.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_LogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_LogOut.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.logout;
            this.nBtn_LogOut.Iconimage_right = null;
            this.nBtn_LogOut.Iconimage_right_Selected = null;
            this.nBtn_LogOut.Iconimage_Selected = null;
            this.nBtn_LogOut.IconMarginLeft = 0;
            this.nBtn_LogOut.IconMarginRight = 0;
            this.nBtn_LogOut.IconRightVisible = true;
            this.nBtn_LogOut.IconRightZoom = 0D;
            this.nBtn_LogOut.IconVisible = true;
            this.nBtn_LogOut.IconZoom = 50D;
            this.nBtn_LogOut.IsTab = true;
            this.nBtn_LogOut.Location = new System.Drawing.Point(2, 429);
            this.nBtn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_LogOut.Name = "nBtn_LogOut";
            this.nBtn_LogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_LogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_LogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.nBtn_LogOut.selected = false;
            this.nBtn_LogOut.Size = new System.Drawing.Size(142, 48);
            this.nBtn_LogOut.TabIndex = 4;
            this.nBtn_LogOut.Text = "Logout";
            this.nBtn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_LogOut.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_LogOut.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_LogOut.Click += new System.EventHandler(this.nBtn_LogOut_Click);
            // 
            // nBtn_Settings
            // 
            this.nBtn_Settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_Settings.BorderRadius = 0;
            this.nBtn_Settings.ButtonText = "Settings";
            this.nBtn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_Settings.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_Settings.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.settings;
            this.nBtn_Settings.Iconimage_right = null;
            this.nBtn_Settings.Iconimage_right_Selected = null;
            this.nBtn_Settings.Iconimage_Selected = null;
            this.nBtn_Settings.IconMarginLeft = 0;
            this.nBtn_Settings.IconMarginRight = 0;
            this.nBtn_Settings.IconRightVisible = true;
            this.nBtn_Settings.IconRightZoom = 0D;
            this.nBtn_Settings.IconVisible = true;
            this.nBtn_Settings.IconZoom = 50D;
            this.nBtn_Settings.IsTab = true;
            this.nBtn_Settings.Location = new System.Drawing.Point(3, 301);
            this.nBtn_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_Settings.Name = "nBtn_Settings";
            this.nBtn_Settings.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.nBtn_Settings.selected = false;
            this.nBtn_Settings.Size = new System.Drawing.Size(142, 48);
            this.nBtn_Settings.TabIndex = 3;
            this.nBtn_Settings.Text = "Settings";
            this.nBtn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_Settings.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Settings.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_Settings.Click += new System.EventHandler(this.nBtn_Settings_Click);
            // 
            // nBtn_Cancel
            // 
            this.nBtn_Cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_Cancel.BorderRadius = 0;
            this.nBtn_Cancel.ButtonText = "Cancel";
            this.nBtn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_Cancel.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.stopwatch;
            this.nBtn_Cancel.Iconimage_right = null;
            this.nBtn_Cancel.Iconimage_right_Selected = null;
            this.nBtn_Cancel.Iconimage_Selected = null;
            this.nBtn_Cancel.IconMarginLeft = 0;
            this.nBtn_Cancel.IconMarginRight = 0;
            this.nBtn_Cancel.IconRightVisible = true;
            this.nBtn_Cancel.IconRightZoom = 0D;
            this.nBtn_Cancel.IconVisible = true;
            this.nBtn_Cancel.IconZoom = 50D;
            this.nBtn_Cancel.IsTab = true;
            this.nBtn_Cancel.Location = new System.Drawing.Point(3, 254);
            this.nBtn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_Cancel.Name = "nBtn_Cancel";
            this.nBtn_Cancel.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_Cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.nBtn_Cancel.selected = false;
            this.nBtn_Cancel.Size = new System.Drawing.Size(142, 48);
            this.nBtn_Cancel.TabIndex = 2;
            this.nBtn_Cancel.Text = "Cancel";
            this.nBtn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_Cancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Cancel.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_Cancel.Click += new System.EventHandler(this.nBtn_Cancel_Click);
            // 
            // nBtn_Reserve
            // 
            this.nBtn_Reserve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_Reserve.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_Reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_Reserve.BorderRadius = 0;
            this.nBtn_Reserve.ButtonText = "Reserve";
            this.nBtn_Reserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_Reserve.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_Reserve.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_Reserve.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.calendar;
            this.nBtn_Reserve.Iconimage_right = null;
            this.nBtn_Reserve.Iconimage_right_Selected = null;
            this.nBtn_Reserve.Iconimage_Selected = null;
            this.nBtn_Reserve.IconMarginLeft = 0;
            this.nBtn_Reserve.IconMarginRight = 0;
            this.nBtn_Reserve.IconRightVisible = true;
            this.nBtn_Reserve.IconRightZoom = 0D;
            this.nBtn_Reserve.IconVisible = true;
            this.nBtn_Reserve.IconZoom = 50D;
            this.nBtn_Reserve.IsTab = true;
            this.nBtn_Reserve.Location = new System.Drawing.Point(3, 208);
            this.nBtn_Reserve.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_Reserve.Name = "nBtn_Reserve";
            this.nBtn_Reserve.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_Reserve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_Reserve.OnHoverTextColor = System.Drawing.Color.White;
            this.nBtn_Reserve.selected = false;
            this.nBtn_Reserve.Size = new System.Drawing.Size(142, 48);
            this.nBtn_Reserve.TabIndex = 1;
            this.nBtn_Reserve.Text = "Reserve";
            this.nBtn_Reserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_Reserve.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Reserve.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_Reserve.Click += new System.EventHandler(this.nBtn_Reserve_Click);
            // 
            // nBtn_Home
            // 
            this.nBtn_Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            this.nBtn_Home.BackColor = System.Drawing.Color.Transparent;
            this.nBtn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nBtn_Home.BorderRadius = 0;
            this.nBtn_Home.ButtonText = "Home";
            this.nBtn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nBtn_Home.DisabledColor = System.Drawing.Color.Gray;
            this.nBtn_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.nBtn_Home.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.home__2_;
            this.nBtn_Home.Iconimage_right = null;
            this.nBtn_Home.Iconimage_right_Selected = null;
            this.nBtn_Home.Iconimage_Selected = null;
            this.nBtn_Home.IconMarginLeft = 0;
            this.nBtn_Home.IconMarginRight = 0;
            this.nBtn_Home.IconRightVisible = true;
            this.nBtn_Home.IconRightZoom = 0D;
            this.nBtn_Home.IconVisible = true;
            this.nBtn_Home.IconZoom = 50D;
            this.nBtn_Home.IsTab = true;
            this.nBtn_Home.Location = new System.Drawing.Point(3, 161);
            this.nBtn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.nBtn_Home.Name = "nBtn_Home";
            this.nBtn_Home.Normalcolor = System.Drawing.Color.Transparent;
            this.nBtn_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.nBtn_Home.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Home.selected = false;
            this.nBtn_Home.Size = new System.Drawing.Size(142, 48);
            this.nBtn_Home.TabIndex = 0;
            this.nBtn_Home.Text = "Home";
            this.nBtn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nBtn_Home.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.nBtn_Home.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBtn_Home.Click += new System.EventHandler(this.nBtn_Home_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.p_DashControl);
            this.Controls.Add(this.p_DashNav);
            this.Controls.Add(this.p_DashHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.p_DashNav.ResumeLayout(false);
            this.p_DashHeader.ResumeLayout(false);
            this.p_DashHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel p_DashHeader;
        private System.Windows.Forms.Panel p_DashNav;
        private System.Windows.Forms.Panel p_DashControl;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_Home;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_Settings;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_Reserve;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_Exit;
        private Bunifu.Framework.UI.BunifuFlatButton nBtn_LogOut;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Header;
        private Header header1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

