namespace Lab_Reservation_ISD
{
    partial class ReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmb_TimeSlot = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Device = new MetroFramework.Controls.MetroComboBox();
            this.tp_Date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btn_Reserve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_Reservations = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.r_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmb_TimeSlot
            // 
            this.cmb_TimeSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cmb_TimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_TimeSlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.cmb_TimeSlot.FormattingEnabled = true;
            this.cmb_TimeSlot.ItemHeight = 23;
            this.cmb_TimeSlot.Location = new System.Drawing.Point(298, 78);
            this.cmb_TimeSlot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_TimeSlot.Name = "cmb_TimeSlot";
            this.cmb_TimeSlot.Size = new System.Drawing.Size(225, 29);
            this.cmb_TimeSlot.TabIndex = 0;
            this.cmb_TimeSlot.UseCustomBackColor = true;
            this.cmb_TimeSlot.UseCustomForeColor = true;
            this.cmb_TimeSlot.UseSelectable = true;
            // 
            // cmb_Device
            // 
            this.cmb_Device.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cmb_Device.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Device.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.cmb_Device.FormattingEnabled = true;
            this.cmb_Device.ItemHeight = 23;
            this.cmb_Device.Location = new System.Drawing.Point(298, 120);
            this.cmb_Device.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Device.Name = "cmb_Device";
            this.cmb_Device.Size = new System.Drawing.Size(225, 29);
            this.cmb_Device.TabIndex = 1;
            this.cmb_Device.UseCustomBackColor = true;
            this.cmb_Device.UseCustomForeColor = true;
            this.cmb_Device.UseSelectable = true;
            this.cmb_Device.UseStyleColors = true;
            // 
            // tp_Date
            // 
            this.tp_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.tp_Date.BorderRadius = 0;
            this.tp_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.tp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tp_Date.FormatCustom = null;
            this.tp_Date.Location = new System.Drawing.Point(298, 170);
            this.tp_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Date.Name = "tp_Date";
            this.tp_Date.Size = new System.Drawing.Size(224, 32);
            this.tp_Date.TabIndex = 2;
            this.tp_Date.Value = new System.DateTime(2018, 11, 27, 17, 10, 25, 444);
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.btn_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reserve.BorderRadius = 0;
            this.btn_Reserve.ButtonText = "Request Slot";
            this.btn_Reserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reserve.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Reserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.btn_Reserve.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Reserve.Iconimage = null;
            this.btn_Reserve.Iconimage_right = null;
            this.btn_Reserve.Iconimage_right_Selected = null;
            this.btn_Reserve.Iconimage_Selected = null;
            this.btn_Reserve.IconMarginLeft = 0;
            this.btn_Reserve.IconMarginRight = 0;
            this.btn_Reserve.IconRightVisible = true;
            this.btn_Reserve.IconRightZoom = 0D;
            this.btn_Reserve.IconVisible = true;
            this.btn_Reserve.IconZoom = 90D;
            this.btn_Reserve.IsTab = false;
            this.btn_Reserve.Location = new System.Drawing.Point(298, 223);
            this.btn_Reserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_Reserve.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Reserve.selected = false;
            this.btn_Reserve.Size = new System.Drawing.Size(224, 37);
            this.btn_Reserve.TabIndex = 3;
            this.btn_Reserve.Text = "Request Slot";
            this.btn_Reserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reserve.Textcolor = System.Drawing.Color.White;
            this.btn_Reserve.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reserve.Click += new System.EventHandler(this.btn_MakeReserve_Click);
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
            this.dgv_Reservations.Location = new System.Drawing.Point(43, 306);
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
            this.dgv_Reservations.TabIndex = 4;
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
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.dgv_Reservations);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.tp_Date);
            this.Controls.Add(this.cmb_Device);
            this.Controls.Add(this.cmb_TimeSlot);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReservationForm";
            this.Size = new System.Drawing.Size(854, 562);
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reserve;
        private Bunifu.Framework.UI.BunifuDatepicker tp_Date;
        private MetroFramework.Controls.MetroComboBox cmb_Device;
        private MetroFramework.Controls.MetroComboBox cmb_TimeSlot;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Reservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
