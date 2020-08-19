namespace Lab_Reservation_ISD
{
    partial class Header
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.hBtn_Window = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hBtn_Exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Clock = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.hBtn_Dock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hBtn_CopyRight = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // hBtn_Window
            // 
            this.hBtn_Window.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hBtn_Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hBtn_Window.BorderRadius = 0;
            this.hBtn_Window.ButtonText = "bunifuFlatButton1";
            this.hBtn_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hBtn_Window.DisabledColor = System.Drawing.Color.Gray;
            this.hBtn_Window.Iconcolor = System.Drawing.Color.Transparent;
            this.hBtn_Window.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.Minimize;
            this.hBtn_Window.Iconimage_right = null;
            this.hBtn_Window.Iconimage_right_Selected = null;
            this.hBtn_Window.Iconimage_Selected = null;
            this.hBtn_Window.IconMarginLeft = 0;
            this.hBtn_Window.IconMarginRight = 0;
            this.hBtn_Window.IconRightVisible = true;
            this.hBtn_Window.IconRightZoom = 0D;
            this.hBtn_Window.IconVisible = true;
            this.hBtn_Window.IconZoom = 58D;
            this.hBtn_Window.IsTab = false;
            this.hBtn_Window.Location = new System.Drawing.Point(422, 0);
            this.hBtn_Window.Name = "hBtn_Window";
            this.hBtn_Window.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Window.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hBtn_Window.OnHoverTextColor = System.Drawing.Color.White;
            this.hBtn_Window.selected = false;
            this.hBtn_Window.Size = new System.Drawing.Size(40, 39);
            this.hBtn_Window.TabIndex = 6;
            this.hBtn_Window.Text = "bunifuFlatButton1";
            this.hBtn_Window.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hBtn_Window.Textcolor = System.Drawing.Color.White;
            this.hBtn_Window.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // hBtn_Exit
            // 
            this.hBtn_Exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hBtn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hBtn_Exit.BorderRadius = 0;
            this.hBtn_Exit.ButtonText = "bunifuFlatButton2";
            this.hBtn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hBtn_Exit.DisabledColor = System.Drawing.Color.Gray;
            this.hBtn_Exit.Iconcolor = System.Drawing.Color.Transparent;
            this.hBtn_Exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("hBtn_Exit.Iconimage")));
            this.hBtn_Exit.Iconimage_right = null;
            this.hBtn_Exit.Iconimage_right_Selected = null;
            this.hBtn_Exit.Iconimage_Selected = null;
            this.hBtn_Exit.IconMarginLeft = 0;
            this.hBtn_Exit.IconMarginRight = 0;
            this.hBtn_Exit.IconRightVisible = true;
            this.hBtn_Exit.IconRightZoom = 0D;
            this.hBtn_Exit.IconVisible = true;
            this.hBtn_Exit.IconZoom = 58D;
            this.hBtn_Exit.IsTab = false;
            this.hBtn_Exit.Location = new System.Drawing.Point(462, 0);
            this.hBtn_Exit.Name = "hBtn_Exit";
            this.hBtn_Exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hBtn_Exit.OnHoverTextColor = System.Drawing.Color.White;
            this.hBtn_Exit.selected = false;
            this.hBtn_Exit.Size = new System.Drawing.Size(40, 39);
            this.hBtn_Exit.TabIndex = 7;
            this.hBtn_Exit.Text = "bunifuFlatButton2";
            this.hBtn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hBtn_Exit.Textcolor = System.Drawing.Color.White;
            this.hBtn_Exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hBtn_Exit.Click += new System.EventHandler(this.hBtn_Exit_Click);
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Clock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_Clock.Location = new System.Drawing.Point(115, 8);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(200, 22);
            this.lbl_Clock.TabIndex = 8;
            this.lbl_Clock.Text = "bunifuCustomLabel1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hBtn_Dock
            // 
            this.hBtn_Dock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hBtn_Dock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Dock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hBtn_Dock.BorderRadius = 0;
            this.hBtn_Dock.ButtonText = "bunifuFlatButton4";
            this.hBtn_Dock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hBtn_Dock.DisabledColor = System.Drawing.Color.Gray;
            this.hBtn_Dock.Iconcolor = System.Drawing.Color.Transparent;
            this.hBtn_Dock.Iconimage = global::Lab_Reservation_ISD.Properties.Resources.ToDock;
            this.hBtn_Dock.Iconimage_right = null;
            this.hBtn_Dock.Iconimage_right_Selected = null;
            this.hBtn_Dock.Iconimage_Selected = null;
            this.hBtn_Dock.IconMarginLeft = 0;
            this.hBtn_Dock.IconMarginRight = 0;
            this.hBtn_Dock.IconRightVisible = true;
            this.hBtn_Dock.IconRightZoom = 0D;
            this.hBtn_Dock.IconVisible = true;
            this.hBtn_Dock.IconZoom = 58D;
            this.hBtn_Dock.IsTab = false;
            this.hBtn_Dock.Location = new System.Drawing.Point(382, 0);
            this.hBtn_Dock.Name = "hBtn_Dock";
            this.hBtn_Dock.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_Dock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hBtn_Dock.OnHoverTextColor = System.Drawing.Color.White;
            this.hBtn_Dock.selected = false;
            this.hBtn_Dock.Size = new System.Drawing.Size(40, 39);
            this.hBtn_Dock.TabIndex = 5;
            this.hBtn_Dock.Text = "bunifuFlatButton4";
            this.hBtn_Dock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hBtn_Dock.Textcolor = System.Drawing.Color.White;
            this.hBtn_Dock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // hBtn_CopyRight
            // 
            this.hBtn_CopyRight.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hBtn_CopyRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_CopyRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hBtn_CopyRight.BorderRadius = 0;
            this.hBtn_CopyRight.ButtonText = "bunifuFlatButton4";
            this.hBtn_CopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hBtn_CopyRight.DisabledColor = System.Drawing.Color.Gray;
            this.hBtn_CopyRight.Iconcolor = System.Drawing.Color.Transparent;
            this.hBtn_CopyRight.Iconimage = ((System.Drawing.Image)(resources.GetObject("hBtn_CopyRight.Iconimage")));
            this.hBtn_CopyRight.Iconimage_right = null;
            this.hBtn_CopyRight.Iconimage_right_Selected = null;
            this.hBtn_CopyRight.Iconimage_Selected = null;
            this.hBtn_CopyRight.IconMarginLeft = 0;
            this.hBtn_CopyRight.IconMarginRight = 0;
            this.hBtn_CopyRight.IconRightVisible = true;
            this.hBtn_CopyRight.IconRightZoom = 0D;
            this.hBtn_CopyRight.IconVisible = true;
            this.hBtn_CopyRight.IconZoom = 58D;
            this.hBtn_CopyRight.IsTab = false;
            this.hBtn_CopyRight.Location = new System.Drawing.Point(342, 1);
            this.hBtn_CopyRight.Name = "hBtn_CopyRight";
            this.hBtn_CopyRight.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.hBtn_CopyRight.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.hBtn_CopyRight.OnHoverTextColor = System.Drawing.Color.White;
            this.hBtn_CopyRight.selected = false;
            this.hBtn_CopyRight.Size = new System.Drawing.Size(40, 39);
            this.hBtn_CopyRight.TabIndex = 9;
            this.hBtn_CopyRight.Text = "bunifuFlatButton4";
            this.hBtn_CopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hBtn_CopyRight.Textcolor = System.Drawing.Color.White;
            this.hBtn_CopyRight.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hBtn_CopyRight.Click += new System.EventHandler(this.hBtn_CopyRight_Click);
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.hBtn_CopyRight);
            this.Controls.Add(this.lbl_Clock);
            this.Controls.Add(this.hBtn_Exit);
            this.Controls.Add(this.hBtn_Window);
            this.Controls.Add(this.hBtn_Dock);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(500, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton hBtn_Window;
        private Bunifu.Framework.UI.BunifuFlatButton hBtn_Exit;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_Clock;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuFlatButton hBtn_Dock;
        private Bunifu.Framework.UI.BunifuFlatButton hBtn_CopyRight;
    }
}
