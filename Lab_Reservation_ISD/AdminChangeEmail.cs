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
    public partial class AdminChangeEmail : UserControl
    {
        private SQLConnection _sql;
        private Validate _validate;
        private Admin _admin;

        public AdminChangeEmail(Admin admin)
        {
            InitializeComponent();

            _admin = admin;
            _sql = new SQLConnection();
            _validate = new Validate();
        }

        private void btn_ChangeEmail_Click(object sender, EventArgs e)
        {
            string[] fields = { _admin.a_id.ToString(), txt_currrent.Text, txt_new.Text };
            string[] param = { "a_ID", "a_Email", "a_NewEmail" };
            string sp_Name = "sp_ChangeAdminEmail";


            if (!_validate.checkEmpty(fields))
            {
                _sql.ProcessDB(sp_Name, param, fields);
                MessageBox.Show("Email Updated");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
