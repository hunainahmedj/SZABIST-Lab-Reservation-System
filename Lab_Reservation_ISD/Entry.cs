using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Reservation_ISD
{
    public partial class Entry : Form
    {
        Utils _utils;
        Login _login;
        public Entry()
        {
            _utils = new Utils();
            InitializeComponent();

            _login = new Login();
            _utils.Change_UserControl(_login, p_EntryControl);
        }

        private void tbtn_login_click(object sender, EventArgs e)
        {
            lbl_Header.Text = "Login";
            _login = new Login();
            _utils.Change_UserControl(_login, p_EntryControl);
        }

        private void tBtn_Register_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = "Register";
            Register _register = new Register();
            _utils.Change_UserControl(_register, p_EntryControl);

        }

    }
}
