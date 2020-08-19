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
    public partial class LoginAdmin : Form
    {
        private SqlMng _sqlmng;
        Validate _validate;
        public LoginAdmin( SqlMng mng)
        {
            _validate = new Validate();
            InitializeComponent();
            _sqlmng = mng;
        }

   
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] param = { "a_email", "a_pass" };
            string[] val = { txt_email.Text, txt_pass.Text };
            
            if (!_validate.checkEmpty(val))
            {
                Admin ad = _sqlmng.Login("a_login", param, val);
                if (ad.a_id > 0)
                {
                    if (ad.a_status != 'P')
                    {
                        Admin _admin = new Admin();
                        this.Hide();
                        DashboardAdmin db = new DashboardAdmin(_sqlmng, ad);
                        db.Show();

                    }
                    else
                    {
                        MessageBox.Show("Account Request Waiting for approval");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username Password");
                }
            }
            else
            {
                MessageBox.Show("Please enter Id and Password Both");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp(_sqlmng);
            signup.Show();
            this.Hide();
        }

        private void txt_pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_pass.isPassword = true;
        }
    }
}
