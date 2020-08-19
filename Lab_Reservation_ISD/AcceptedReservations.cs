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
    public partial class AcceptedReservations : UserControl
    {
        private SqlMng _sqlMng;
        Utils _utils;
        public AcceptedReservations(SqlMng mng)
        {

            _utils = new Utils();
            InitializeComponent();
            _sqlMng = mng;
        }
        //SqlMng mng = new SqlMng();
        private void AcceptedReservations_Load(object sender, EventArgs e)
        {
            dgv_AReservations.DataSource = _sqlMng.getTable("sp_view_AReservations");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AReservations.Columns[e.ColumnIndex].Name == "Completed")
            {
                string[] param = { "r_id" };
                int[] val = { Convert.ToInt32(dgv_AReservations.CurrentRow.Cells[1].Value.ToString()) };
                _sqlMng.insertDB("sp_comR", param, val);
                _utils.Load_DataGrid(dgv_AReservations, _sqlMng, "sp_view_AReservations");
            }
        }
    }
}
