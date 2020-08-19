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
    public partial class SignUp : Form
    {
        Validate _validate;
        private SqlMng sqlMng;
        private Utils _utils;

        public SignUp(SqlMng mng)
        {
            _utils = new Utils();
            _validate = new Validate();
            InitializeComponent();
            sqlMng = mng;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool IsValidPass = _validate.IsValidPassword(txt_pass.Text);
            bool IsValidEmail = _validate.IsValidEmail(txt_email.Text);
            bool EmailPresent = _validate.EmailPresent(txt_email.Text);

            if (txt_pass.Text.Equals(txt_c_pass.Text) && IsValidPass && IsValidEmail && !EmailPresent)
            {
                string[] param = { "a_name", "a_email", "a_pass" };
                string[] values = { txt_name.Text, txt_email.Text, txt_pass.Text };
                //SqlMng mng = new SqlMng();

                if (!_validate.checkEmpty(values))
                {
                    sqlMng.insertDB("admin_signup", param, values);
                    MessageBox.Show("Your request has been sent");
                } 
                else
                {
                    MessageBox.Show("All Fields are required!");
                }
                    
            }
            else if (!IsValidPass)
            {
                MessageBox.Show("Password must be more then 6 characters!");
            }
            else if (!IsValidEmail)
            {
                MessageBox.Show("Enter a proper Email");
            }
            else if (EmailPresent)
            {
                MessageBox.Show("Email already in use");
            }
            else if (!txt_pass.Text.Equals(txt_c_pass.Text))
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LoginAdmin la = new LoginAdmin(sqlMng);
            la.Show();
            this.Hide();
        }

        private void txt_pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_pass.isPassword = true;
        }

        private void txt_c_pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_c_pass.isPassword = true;
        }

        private void txt_email_OnValueChanged(object sender, EventArgs e)
        {
            bool isValidEmail = _validate.IsValidEmail(txt_email.Text);

            if (isValidEmail)
            {
                _utils.Revert_FieldColor(txt_email);
            }
            else
            {
                txt_email.Focus();
                _utils.Change_FieldColor(txt_email);
            }
        }
    }
}
