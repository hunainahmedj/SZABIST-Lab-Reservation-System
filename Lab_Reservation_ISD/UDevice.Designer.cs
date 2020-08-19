namespace Lab_Reservation_ISD
{
    partial class UDevice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Devices = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Reserve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Devices = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.std_regID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Devices
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Devices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Devices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Devices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.dgv_Devices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Devices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Devices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Devices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Devices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.std_regID,
            this.Date,
            this.Delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Devices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Devices.DoubleBuffered = true;
            this.dgv_Devices.EnableHeadersVisualStyles = false;
            this.dgv_Devices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.dgv_Devices.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgv_Devices.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Devices.Location = new System.Drawing.Point(2, 260);
            this.dgv_Devices.Name = "dgv_Devices";
            this.dgv_Devices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Devices.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Devices.RowHeadersWidth = 20;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Devices.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Devices.Size = new System.Drawing.Size(724, 361);
            this.dgv_Devices.TabIndex = 8;
            this.dgv_Devices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Devices_CellContentClick);
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.btn_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reserve.BorderRadius = 5;
            this.btn_Reserve.ButtonText = "Add Deivce";
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
            this.btn_Reserve.Location = new System.Drawing.Point(252, 172);
            this.btn_Reserve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_Reserve.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Reserve.selected = false;
            this.btn_Reserve.Size = new System.Drawing.Size(224, 37);
            this.btn_Reserve.TabIndex = 9;
            this.btn_Reserve.Text = "Add Deivce";
            this.btn_Reserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reserve.Textcolor = System.Drawing.Color.White;
            this.btn_Reserve.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reserve.Click += new System.EventHandler(this.btn_AddDevice_Click);
            // 
            // txt_Devices
            // 
            this.txt_Devices.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Devices.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Devices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Devices.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Devices.HintText = "Device Name";
            this.txt_Devices.isPassword = false;
            this.txt_Devices.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_Devices.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_Devices.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_Devices.LineThickness = 3;
            this.txt_Devices.Location = new System.Drawing.Point(225, 94);
            this.txt_Devices.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Devices.Name = "txt_Devices";
            this.txt_Devices.Size = new System.Drawing.Size(278, 36);
            this.txt_Devices.TabIndex = 15;
            this.txt_Devices.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // std_regID
            // 
            this.std_regID.DataPropertyName = "d_Id";
            this.std_regID.HeaderText = "ID";
            this.std_regID.Name = "std_regID";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "d_Name";
            this.Date.HeaderText = "Name";
            this.Date.Name = "Date";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Remove Device";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // UDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.txt_Devices);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.dgv_Devices);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UDevice";
            this.Size = new System.Drawing.Size(728, 624);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Devices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Devices;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reserve;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Devices;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_regID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
