using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Reservation_ISD
{
    public partial class TimeSlots : UserControl
    {
        private SqlMng _sqlMng;
        private SQLConnection _sql;
        private Validate _validate;
        private Utils _utils;

        public TimeSlots(SqlMng mng)
        {
            _validate = new Validate();
            _utils = new Utils();
            InitializeComponent();
            _sqlMng = mng;
            _sql = new SQLConnection();
        }
        //SqlMng mng = new SqlMng();
        private void btn_AddSlots_Click(object sender, EventArgs e)
        {
            string[] param = { "s_name" };
            string[] val = { txt_Slot.Text };

            if (!_validate.checkEmpty(val))
            {
                _sqlMng.insertDB("sp_addSlot", param, val);
            }
            else
            {

            }

        }

        private void TimeSlots_Load(object sender, EventArgs e)
        {
            dgv_Slots.DataSource = _sqlMng.getTable("sp_getSlots");
        }

        private void TimeSlots_Load_1(object sender, EventArgs e)
        {
            dgv_Slots.DataSource = _sqlMng.getTable("sp_getSlots");
        }

        private void dgv_Slots_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Slots.Columns[e.ColumnIndex].Name == "Delete")
            {
                object[] values = { Convert.ToInt32(dgv_Slots.CurrentRow.Cells[1].Value.ToString()) };
                string[] param = { "s_Id" };
                _sql.ProcessDB("sp_RemoveSlot", param, values);
                dgv_Slots.Refresh();
                _utils.Load_DataGrid(dgv_Slots, _sql, "sp_getSlots");
                
            }
        }
    }
}
