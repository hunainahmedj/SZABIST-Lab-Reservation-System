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
    public partial class CancelFrom : UserControl
    {
        SQLConnection _sql;
        Student _student;
        Utils _utils;
        public CancelFrom(object std)
        {
            _student = (Student)std;
            _sql = new SQLConnection();
            _utils = new Utils();
            InitializeComponent();
            _utils.Load_DataGrid(dgv_Reservations, _sql, "Get_Reservations");
        }

        private void btn_CancelReserv_Click(object sender, EventArgs e)
        {
            string sp_Name = "Cancel_Reservation";
            string[] param = { "r_id", "std_id" };
            object[] value = { txt_ReservationId.Text, _student.ID };
            _sql.ProcessDB(sp_Name, param, value);
            dgv_Reservations.Refresh();
            _utils.Load_DataGrid(dgv_Reservations, _sql, "Get_Reservations");

        }
    }
}
