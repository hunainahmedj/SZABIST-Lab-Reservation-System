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
    public partial class AdminReq : UserControl
    {
        private SqlMng _sqlMng;
        private Utils _utils;

        public AdminReq(SqlMng sqlmng)
        {
            InitializeComponent();
            _sqlMng = sqlmng;
            _utils = new Utils();
        }

        //SqlMng mng = new SqlMng();
        private void AdminReq_Load(object sender, EventArgs e)
        {
            dgv_AdminReq.DataSource = _sqlMng.getTable("sp_adminReq_view");
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.Columns[e.ColumnIndex].Name == "Approve")
        //    {
        //        string[] param = { "a_id" };
        //        string[] val = { dataGridView1.CurrentRow.Cells[0].Value.ToString() };
        //        _sqlMng.insertDB("sp_approveAdmin", param, val);
        //    }
        //    else if (dataGridView1.Columns[e.ColumnIndex].Name == "Decline")
        //    {
        //        string[] param = { "a_id" };
        //        string[] val = { dataGridView1.CurrentRow.Cells[0].Value.ToString() };
        //        _sqlMng.insertDB("sp_declineAdmin", param, val);
        //    }
        //}

        private void AdminReq_Load_1(object sender, EventArgs e)
        {
            dgv_AdminReq.DataSource = _sqlMng.getTable("sp_adminReq_view");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AdminReq.Columns[e.ColumnIndex].Name == "Approve")
            {
                string[] param = { "a_id" };
                int[] val = { Convert.ToInt32(dgv_AdminReq.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("sp_approveAdmin", param, val);
                dgv_AdminReq.Refresh();
                _utils.Load_DataGrid(dgv_AdminReq, _sqlMng, "sp_adminReq_view");
                MessageBox.Show("Admin Added");
            }
            else if (dgv_AdminReq.Columns[e.ColumnIndex].Name == "Decline")
            {
                string[] param = { "a_id" };
                int[] val = { Convert.ToInt32(dgv_AdminReq.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("sp_declineAdmin", param, val);
                _utils.Load_DataGrid(dgv_AdminReq, _sqlMng, "sp_adminReq_view");
                dgv_AdminReq.Refresh();
            }
        }
    }
}
