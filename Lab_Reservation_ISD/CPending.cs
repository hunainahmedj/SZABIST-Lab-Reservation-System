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
    public partial class CPending : UserControl
    {
        private SqlMng _sqlMng;
        private Utils _utils;
        public CPending(SqlMng mng)
        {
            _utils = new Utils();
            InitializeComponent();
            _sqlMng = mng;
        }

        //SqlMng mng = new SqlMng();

        private void CPending_Load(object sender, EventArgs e)
        {

            //view pending Requests
            dgv_Pending.DataSource = _sqlMng.getTable("sp_view_cpending");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CPending_Load_1(object sender, EventArgs e)
        {
            dgv_Pending.DataSource = _sqlMng.getTable("sp_view_cpending");

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Pending.Columns[e.ColumnIndex].Name == "Accept")
            {
                MessageBox.Show(dgv_Pending.CurrentRow.Cells[2].Value.ToString());
                string[] param = { "r_id" };
                int[] val = { Convert.ToInt32(dgv_Pending.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("acceptR", param, val);
                dgv_Pending.Refresh();
                _utils.Load_DataGrid(dgv_Pending, new SQLConnection(), "sp_view_cpending");
            }
            else if (dgv_Pending.Columns[e.ColumnIndex].Name == "Reject")
            {
                string[] param = { "r_id" };
                int[] val = { Convert.ToInt32(dgv_Pending.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("rejectR", param, val);
            }
        }

        
    }
}
