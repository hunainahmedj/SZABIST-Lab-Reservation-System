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
    public partial class UDevice : UserControl
    {
        private Validate _validate;
        private Utils _utils;
        private SqlMng _sqlMng;
        private SQLConnection _sql;

        public UDevice(SqlMng mng)
        {
            _validate = new Validate();
            _utils = new Utils();
            _sql = new SQLConnection();

            InitializeComponent();
            _sqlMng = mng;
            _utils.Load_DataGrid(dgv_Devices, _sqlMng, "sp_getDevices");
        }

        //SqlMng mng = new SqlMng();
    


        private void btn_AddDevice_Click(object sender, EventArgs e)
        {
            string[] param = { "d_name" };
            string[] val = { txt_Devices.Text };
            if (!_validate.checkEmpty(val))
            {
                _sqlMng.insertDB("add_device", param, val);
                _utils.Load_DataGrid(dgv_Devices, _sqlMng, "sp_getDevices");
            } 
            else
            {
                MessageBox.Show("Please provide the Device Name");
            }
            
            // dataGridView1.Refresh();
        }

        private void dgv_Devices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Devices.Columns[e.ColumnIndex].Name == "Delete")
            {
                object[] values = { Convert.ToInt32(dgv_Devices.CurrentRow.Cells[1].Value.ToString()) };
                string[] param = { "d_Id" };
                _sql.ProcessDB("sp_RemoveDevice", param, values);
                dgv_Devices.Refresh();
                _utils.Load_DataGrid(dgv_Devices, _sql, "sp_getDevices");

            }
        }
    }
}
