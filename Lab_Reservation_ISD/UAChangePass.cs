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
    public partial class UAChangePass : UserControl
    {
        private SQLConnection _sql;
        private Validate _validate;
        private Admin _admin;


        public UAChangePass(Admin admin)
        {
            InitializeComponent();

            _admin = admin;
            _sql = new SQLConnection();
            _validate = new Validate();
        }

        private void btn_ChangePass_click(object sender, EventArgs e)
        {
            string[] fields = { _admin.a_id.ToString(), txt_currrent.Text, txt_new.Text};
            string[] param = { "a_ID", "a_Pass", "a_NewPass" };
            string sp_Name = "sp_ChangeAdminPass";


            if (!_validate.checkEmpty(fields))
            {
                _sql.ProcessDB( sp_Name, param, fields);
                MessageBox.Show("Password Updated");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            
        }
    }
}
