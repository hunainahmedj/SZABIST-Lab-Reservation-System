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
    public partial class AccountSettingsControl : UserControl
    {
        private SqlMng _sqlMng;
        private Utils _utils;
        private Admin _admin;
        public AccountSettingsControl(SqlMng sqlmng, Admin admin)
        {

            InitializeComponent();

            _admin = admin;
            _sqlMng = sqlmng;
            _utils = new Utils();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
            this.Hide();
        }

        private void btn_C_Dashboard_Click(object sender, EventArgs e)
        {
            p_SettingsBoard.Controls.Clear();
        }

        private void btn_C_ChangePass_Click(object sender, EventArgs e)
        {
            _utils.Change_UserControl(new UAChangePass(_admin), p_SettingsBoard);
        }

        private void btn_ChangeEmail_Click(object sender, EventArgs e)
        {
            _utils.Change_UserControl(new AdminChangeEmail(_admin), p_SettingsBoard);
        }
    }
}
