namespace Lab_Reservation_ISD
{
    partial class Home
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
            this.card_Extra = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.card_ProfileDetails = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_ProfDesig = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ProfName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ProfID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ProfDetTab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card_Reservations = new Bunifu.Framework.UI.BunifuCards();
            this.lbl_ReservationDates = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ReservationStatus = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_ReservationNo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.card_ProfilePic = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ImageUpload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pic_UserDisplay = new System.Windows.Forms.PictureBox();
            this.card_Extra.SuspendLayout();
            this.card_ProfileDetails.SuspendLayout();
            this.card_Reservations.SuspendLayout();
            this.card_ProfilePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // card_Extra
            // 
            this.card_Extra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.card_Extra.BorderRadius = 5;
            this.card_Extra.BottomSahddow = true;
            this.card_Extra.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.card_Extra.Controls.Add(this.bunifuProgressBar2);
            this.card_Extra.Controls.Add(this.bunifuProgressBar1);
            this.card_Extra.LeftSahddow = false;
            this.card_Extra.Location = new System.Drawing.Point(472, 310);
            this.card_Extra.Name = "card_Extra";
            this.card_Extra.RightSahddow = true;
            this.card_Extra.ShadowDepth = 20;
            this.card_Extra.Size = new System.Drawing.Size(341, 190);
            this.card_Extra.TabIndex = 3;
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(22, 141);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(299, 10);
            this.bunifuProgressBar2.TabIndex = 3;
            this.bunifuProgressBar2.Value = 0;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(22, 74);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(299, 10);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            // 
            // card_ProfileDetails
            // 
            this.card_ProfileDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.card_ProfileDetails.BorderRadius = 5;
            this.card_ProfileDetails.BottomSahddow = true;
            this.card_ProfileDetails.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.card_ProfileDetails.Controls.Add(this.lbl_ProfDesig);
            this.card_ProfileDetails.Controls.Add(this.lbl_ProfName);
            this.card_ProfileDetails.Controls.Add(this.lbl_ProfID);
            this.card_ProfileDetails.Controls.Add(this.lbl_ProfDetTab);
            this.card_ProfileDetails.LeftSahddow = false;
            this.card_ProfileDetails.Location = new System.Drawing.Point(472, 63);
            this.card_ProfileDetails.Name = "card_ProfileDetails";
            this.card_ProfileDetails.RightSahddow = true;
            this.card_ProfileDetails.ShadowDepth = 20;
            this.card_ProfileDetails.Size = new System.Drawing.Size(341, 190);
            this.card_ProfileDetails.TabIndex = 4;
            // 
            // lbl_ProfDesig
            // 
            this.lbl_ProfDesig.AutoSize = true;
            this.lbl_ProfDesig.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfDesig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ProfDesig.Location = new System.Drawing.Point(43, 134);
            this.lbl_ProfDesig.Name = "lbl_ProfDesig";
            this.lbl_ProfDesig.Size = new System.Drawing.Size(111, 21);
            this.lbl_ProfDesig.TabIndex = 5;
            this.lbl_ProfDesig.Text = "Designation: ";
            // 
            // lbl_ProfName
            // 
            this.lbl_ProfName.AutoSize = true;
            this.lbl_ProfName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ProfName.Location = new System.Drawing.Point(43, 101);
            this.lbl_ProfName.Name = "lbl_ProfName";
            this.lbl_ProfName.Size = new System.Drawing.Size(66, 21);
            this.lbl_ProfName.TabIndex = 4;
            this.lbl_ProfName.Text = "Name: ";
            // 
            // lbl_ProfID
            // 
            this.lbl_ProfID.AutoSize = true;
            this.lbl_ProfID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ProfID.Location = new System.Drawing.Point(43, 67);
            this.lbl_ProfID.Name = "lbl_ProfID";
            this.lbl_ProfID.Size = new System.Drawing.Size(35, 21);
            this.lbl_ProfID.TabIndex = 3;
            this.lbl_ProfID.Text = "ID: ";
            // 
            // lbl_ProfDetTab
            // 
            this.lbl_ProfDetTab.AutoSize = true;
            this.lbl_ProfDetTab.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProfDetTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ProfDetTab.Location = new System.Drawing.Point(15, 23);
            this.lbl_ProfDetTab.Name = "lbl_ProfDetTab";
            this.lbl_ProfDetTab.Size = new System.Drawing.Size(137, 22);
            this.lbl_ProfDetTab.TabIndex = 2;
            this.lbl_ProfDetTab.Text = "Profile Details: ";
            // 
            // card_Reservations
            // 
            this.card_Reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.card_Reservations.BorderRadius = 5;
            this.card_Reservations.BottomSahddow = true;
            this.card_Reservations.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.card_Reservations.Controls.Add(this.lbl_ReservationDates);
            this.card_Reservations.Controls.Add(this.lbl_ReservationStatus);
            this.card_Reservations.Controls.Add(this.lbl_ReservationNo);
            this.card_Reservations.Controls.Add(this.bunifuCustomLabel5);
            this.card_Reservations.LeftSahddow = false;
            this.card_Reservations.Location = new System.Drawing.Point(42, 310);
            this.card_Reservations.Name = "card_Reservations";
            this.card_Reservations.RightSahddow = true;
            this.card_Reservations.ShadowDepth = 20;
            this.card_Reservations.Size = new System.Drawing.Size(341, 190);
            this.card_Reservations.TabIndex = 5;
            // 
            // lbl_ReservationDates
            // 
            this.lbl_ReservationDates.AutoSize = true;
            this.lbl_ReservationDates.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReservationDates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ReservationDates.Location = new System.Drawing.Point(40, 141);
            this.lbl_ReservationDates.Name = "lbl_ReservationDates";
            this.lbl_ReservationDates.Size = new System.Drawing.Size(154, 21);
            this.lbl_ReservationDates.TabIndex = 9;
            this.lbl_ReservationDates.Text = "Reservation Date: ";
            // 
            // lbl_ReservationStatus
            // 
            this.lbl_ReservationStatus.AutoSize = true;
            this.lbl_ReservationStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReservationStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ReservationStatus.Location = new System.Drawing.Point(40, 108);
            this.lbl_ReservationStatus.Name = "lbl_ReservationStatus";
            this.lbl_ReservationStatus.Size = new System.Drawing.Size(159, 21);
            this.lbl_ReservationStatus.TabIndex = 8;
            this.lbl_ReservationStatus.Text = "Reservation Status:";
            // 
            // lbl_ReservationNo
            // 
            this.lbl_ReservationNo.AutoSize = true;
            this.lbl_ReservationNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReservationNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.lbl_ReservationNo.Location = new System.Drawing.Point(40, 74);
            this.lbl_ReservationNo.Name = "lbl_ReservationNo";
            this.lbl_ReservationNo.Size = new System.Drawing.Size(126, 21);
            this.lbl_ReservationNo.TabIndex = 7;
            this.lbl_ReservationNo.Text = "Reservation #: ";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 30);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(131, 22);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Reservations:";
            // 
            // card_ProfilePic
            // 
            this.card_ProfilePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.card_ProfilePic.BorderRadius = 5;
            this.card_ProfilePic.BottomSahddow = true;
            this.card_ProfilePic.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(249)))));
            this.card_ProfilePic.Controls.Add(this.pic_UserDisplay);
            this.card_ProfilePic.Controls.Add(this.btn_ImageUpload);
            this.card_ProfilePic.Controls.Add(this.bunifuCustomLabel6);
            this.card_ProfilePic.LeftSahddow = false;
            this.card_ProfilePic.Location = new System.Drawing.Point(42, 63);
            this.card_ProfilePic.Name = "card_ProfilePic";
            this.card_ProfilePic.RightSahddow = true;
            this.card_ProfilePic.ShadowDepth = 20;
            this.card_ProfilePic.Size = new System.Drawing.Size(341, 190);
            this.card_ProfilePic.TabIndex = 2;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(12, 23);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(141, 22);
            this.bunifuCustomLabel6.TabIndex = 3;
            this.bunifuCustomLabel6.Text = "Profile Picture: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ImageUpload
            // 
            this.btn_ImageUpload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.btn_ImageUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_ImageUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ImageUpload.BorderRadius = 0;
            this.btn_ImageUpload.ButtonText = "Upload Image";
            this.btn_ImageUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImageUpload.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ImageUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_ImageUpload.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ImageUpload.Iconimage = null;
            this.btn_ImageUpload.Iconimage_right = null;
            this.btn_ImageUpload.Iconimage_right_Selected = null;
            this.btn_ImageUpload.Iconimage_Selected = null;
            this.btn_ImageUpload.IconMarginLeft = 0;
            this.btn_ImageUpload.IconMarginRight = 0;
            this.btn_ImageUpload.IconRightVisible = true;
            this.btn_ImageUpload.IconRightZoom = 0D;
            this.btn_ImageUpload.IconVisible = true;
            this.btn_ImageUpload.IconZoom = 90D;
            this.btn_ImageUpload.IsTab = false;
            this.btn_ImageUpload.Location = new System.Drawing.Point(58, 101);
            this.btn_ImageUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ImageUpload.Name = "btn_ImageUpload";
            this.btn_ImageUpload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_ImageUpload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_ImageUpload.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ImageUpload.selected = false;
            this.btn_ImageUpload.Size = new System.Drawing.Size(224, 37);
            this.btn_ImageUpload.TabIndex = 6;
            this.btn_ImageUpload.Text = "Upload Image";
            this.btn_ImageUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImageUpload.Textcolor = System.Drawing.Color.White;
            this.btn_ImageUpload.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImageUpload.Click += new System.EventHandler(this.btn_ImageUpload_Click);
            // 
            // pic_UserDisplay
            // 
            this.pic_UserDisplay.InitialImage = null;
            this.pic_UserDisplay.Location = new System.Drawing.Point(94, 53);
            this.pic_UserDisplay.Name = "pic_UserDisplay";
            this.pic_UserDisplay.Size = new System.Drawing.Size(142, 123);
            this.pic_UserDisplay.TabIndex = 7;
            this.pic_UserDisplay.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.card_Extra);
            this.Controls.Add(this.card_ProfileDetails);
            this.Controls.Add(this.card_Reservations);
            this.Controls.Add(this.card_ProfilePic);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(854, 562);
            this.Load += new System.EventHandler(this.Home_Load);
            this.card_Extra.ResumeLayout(false);
            this.card_ProfileDetails.ResumeLayout(false);
            this.card_ProfileDetails.PerformLayout();
            this.card_Reservations.ResumeLayout(false);
            this.card_Reservations.PerformLayout();
            this.card_ProfilePic.ResumeLayout(false);
            this.card_ProfilePic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UserDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards card_Extra;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCards card_ProfileDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ProfDesig;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ProfName;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ProfID;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ProfDetTab;
        private Bunifu.Framework.UI.BunifuCards card_Reservations;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ReservationDates;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ReservationStatus;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_ReservationNo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCards card_ProfilePic;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ImageUpload;
        private System.Windows.Forms.PictureBox pic_UserDisplay;
    }
}
