namespace Lab_Reservation_ISD
{
    partial class TimeSlots
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
            this.btn_Reserve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgv_Slots = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_Slot = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.std_regID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Slots)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.btn_Reserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reserve.BorderRadius = 5;
            this.btn_Reserve.ButtonText = "Add Slot";
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
            this.btn_Reserve.Location = new System.Drawing.Point(251, 176);
            this.btn_Reserve.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Reserve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.btn_Reserve.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Reserve.selected = false;
            this.btn_Reserve.Size = new System.Drawing.Size(224, 37);
            this.btn_Reserve.TabIndex = 12;
            this.btn_Reserve.Text = "Add Slot";
            this.btn_Reserve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reserve.Textcolor = System.Drawing.Color.White;
            this.btn_Reserve.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reserve.Click += new System.EventHandler(this.btn_AddSlots_Click);
            // 
            // dgv_Slots
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Slots.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Slots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Slots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.dgv_Slots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Slots.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Slots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Slots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Slots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgv_Slots.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Slots.DoubleBuffered = true;
            this.dgv_Slots.EnableHeadersVisualStyles = false;
            this.dgv_Slots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.dgv_Slots.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgv_Slots.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Slots.Location = new System.Drawing.Point(1, 260);
            this.dgv_Slots.Name = "dgv_Slots";
            this.dgv_Slots.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Slots.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Slots.RowHeadersWidth = 20;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Slots.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Slots.Size = new System.Drawing.Size(724, 364);
            this.dgv_Slots.TabIndex = 11;
            this.dgv_Slots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Slots_CellContentClick);
            // 
            // txt_Slot
            // 
            this.txt_Slot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Slot.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Slot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Slot.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.txt_Slot.HintText = "Slot Name";
            this.txt_Slot.isPassword = false;
            this.txt_Slot.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(181)))));
            this.txt_Slot.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.txt_Slot.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(198)))));
            this.txt_Slot.LineThickness = 3;
            this.txt_Slot.Location = new System.Drawing.Point(224, 97);
            this.txt_Slot.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Slot.Name = "txt_Slot";
            this.txt_Slot.Size = new System.Drawing.Size(278, 36);
            this.txt_Slot.TabIndex = 14;
            this.txt_Slot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // std_regID
            // 
            this.std_regID.DataPropertyName = "s_Id";
            this.std_regID.HeaderText = "ID";
            this.std_regID.Name = "std_regID";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "s_Name";
            this.Date.HeaderText = "Name";
            this.Date.Name = "Date";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Remove";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Remove";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // TimeSlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.Controls.Add(this.txt_Slot);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.dgv_Slots);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimeSlots";
            this.Size = new System.Drawing.Size(728, 624);
            this.Load += new System.EventHandler(this.TimeSlots_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Slots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reserve;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Slots;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_regID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
