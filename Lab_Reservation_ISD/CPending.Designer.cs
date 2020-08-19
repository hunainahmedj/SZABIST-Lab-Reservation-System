namespace Lab_Reservation_ISD
{
    partial class CPending
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Pending = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.r_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std_regID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Reject = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pending)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pending
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Pending.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Pending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pending.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.dgv_Pending.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Pending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pending.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_ID,
            this.std_regID,
            this.Date,
            this.Device,
            this.Slot,
            this.Status,
            this.Accept,
            this.Reject});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Pending.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Pending.DoubleBuffered = true;
            this.dgv_Pending.EnableHeadersVisualStyles = false;
            this.dgv_Pending.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            this.dgv_Pending.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.dgv_Pending.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Pending.Location = new System.Drawing.Point(1, 283);
            this.dgv_Pending.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Pending.Name = "dgv_Pending";
            this.dgv_Pending.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Pending.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Pending.RowHeadersWidth = 20;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(227)))));
            this.dgv_Pending.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Pending.Size = new System.Drawing.Size(966, 215);
            this.dgv_Pending.TabIndex = 5;
            this.dgv_Pending.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // r_ID
            // 
            this.r_ID.DataPropertyName = "r_ID";
            this.r_ID.HeaderText = "Reg ID";
            this.r_ID.Name = "r_ID";
            // 
            // std_regID
            // 
            this.std_regID.DataPropertyName = "std_regId";
            this.std_regID.HeaderText = "Student ID";
            this.std_regID.Name = "std_regID";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "r_date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Device
            // 
            this.Device.DataPropertyName = "d_name";
            this.Device.HeaderText = "Device";
            this.Device.Name = "Device";
            // 
            // Slot
            // 
            this.Slot.DataPropertyName = "s_name";
            this.Slot.HeaderText = "Time Slot";
            this.Slot.Name = "Slot";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "r_status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Accept
            // 
            this.Accept.HeaderText = "Accept";
            this.Accept.Name = "Accept";
            this.Accept.Text = "Accept";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // Reject
            // 
            this.Reject.HeaderText = "Reject";
            this.Reject.Name = "Reject";
            this.Reject.Text = "Reject";
            this.Reject.UseColumnTextForButtonValue = true;
            // 
            // CPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dgv_Pending);
            this.Name = "CPending";
            this.Size = new System.Drawing.Size(970, 768);
            this.Load += new System.EventHandler(this.CPending_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Pending;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn std_regID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.DataGridViewButtonColumn Reject;
    }
}
