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
    public partial class CUserReq : UserControl
    {
        private SqlMng _sqlMng;
        private Utils _utils;

        public CUserReq(SqlMng mng)
        {
            InitializeComponent();
            _sqlMng = mng;
            _utils = new Utils();
        }
        
        private void CUserReq_Load(object sender, EventArgs e)
        {
            dgv_UserReq.DataSource = _sqlMng.getTable("sp_getusers");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgv_UserReq.Columns[e.ColumnIndex].Name == "Allow")
            {
                string[] param = { "std_id" };
                int[] val =  { Convert.ToInt32(dgv_UserReq.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("sp_approveUser", param, val);
                dgv_UserReq.Refresh();
                _utils.Load_DataGrid(dgv_UserReq,_sqlMng,"sp_getusers");
                
            }
            else if (dgv_UserReq.Columns[e.ColumnIndex].Name == "Decline")
            {
                string[] param = { "std_id" };
                int[] val = { Convert.ToInt32(dgv_UserReq.CurrentRow.Cells[2].Value.ToString()) };
                _sqlMng.insertDB("sp_declineUser", param, val);
                dgv_UserReq.Refresh();
                _utils.Load_DataGrid(dgv_UserReq, _sqlMng, "sp_getusers");
            }
        }
    }
}
