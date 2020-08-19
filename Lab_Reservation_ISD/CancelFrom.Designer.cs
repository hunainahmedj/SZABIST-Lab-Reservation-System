namespace Lab_Reservation_ISD
{
    partial class CancelFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelFrom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_ReservationId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_CancelReserv = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgv_Reservations = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.r_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ReservationId
            // 
            this.txt_ReservationId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReservationId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ReservationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ReservationId.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_ReservationId.HintText = "Reservation ID";
            this.txt_ReservationId.isPassword = false;
            this.txt_ReservationId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_ReservationId.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_ReservationId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_ReservationId.LineThickness = 3;
            this.txt_ReservationId.Location = new System.Drawing.Point(290, 113);
            this.txt_ReservationId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReservationId.Name = "txt_ReservationId";
            this.txt_ReservationId.Size = new System.Drawing.Size(278, 36);
            this.txt_ReservationId.TabIndex = 3;
            this.txt_ReservationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_CancelReserv
            // 
            this.btn_CancelReserv.ActiveBorderThickness = 1;
            this.btn_CancelReserv.ActiveCornerRadius = 3;
            this.btn_CancelReserv.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_CancelReserv.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_CancelReserv.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_CancelReserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.btn_CancelReserv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CancelReserv.BackgroundImage")));
            this.btn_CancelReserv.ButtonText = "Cancel";
            this.btn_CancelReserv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelReserv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelReserv.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_CancelReserv.IdleBorderThickness = 1;
            this.btn_CancelReserv.IdleCornerRadius = 3;
            this.btn_CancelReserv.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_CancelReserv.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_CancelReserv.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_CancelReserv.Location = new System.Drawing.Point(362, 443);
            this.btn_CancelReserv.Margin = new System.Windows.Forms.Padding(5);
            this.btn_CancelReserv.Name = "btn_CancelReserv";
            this.btn_CancelReserv.Size = new System.Drawing.Size(135, 50);
            this.btn_CancelReserv.TabIndex = 4;
            this.btn_CancelReserv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CancelReserv.Click += new System.EventHandler(this.btn_CancelReserv_Click);
            // 
            // dgv_Reservations
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Reservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Reservations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.dgv_Reservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Reservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_ID,
            this.Date,
            this.Device,
            this.Slot,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Reservations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Reservations.DoubleBuffered = true;
            this.dgv_Reservations.EnableHeadersVisualStyles = false;
            this.dgv_Reservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.dgv_Reservations.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgv_Reservations.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Reservations.Location = new System.Drawing.Point(43, 194);
            this.dgv_Reservations.Name = "dgv_Reservations";
            this.dgv_Reservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Reservations.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Reservations.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Reservations.Size = new System.Drawing.Size(772, 175);
            this.dgv_Reservations.TabIndex = 5;
            // 
            // r_ID
            // 
            this.r_ID.DataPropertyName = "r_ID";
            this.r_ID.HeaderText = "Registration ID";
            this.r_ID.Name = "r_ID";
            this.r_ID.Width = 150;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "r_Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // Device
            // 
            this.Device.DataPropertyName = "d_name";
            this.Device.HeaderText = "Device";
            this.Device.Name = "Device";
            this.Device.Width = 150;
            // 
            // Slot
            // 
            this.Slot.DataPropertyName = "s_name";
            this.Slot.HeaderText = "Time Slot";
            this.Slot.Name = "Slot";
            this.Slot.Width = 150;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "r_status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // CancelFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.dgv_Reservations);
            this.Controls.Add(this.btn_CancelReserv);
            this.Controls.Add(this.txt_ReservationId);
            this.Name = "CancelFrom";
            this.Size = new System.Drawing.Size(854, 562);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btn_CancelReserv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ReservationId;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Reservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
