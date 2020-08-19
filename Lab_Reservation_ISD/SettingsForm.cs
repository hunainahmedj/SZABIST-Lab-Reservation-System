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
    public partial class SettingsForm : UserControl
    {
        Student _student;
        Validate _validate;
        Utils _utils;
        SQLConnection _sql;

        public SettingsForm(Object std)
        {
            _sql = new SQLConnection();
            _utils = new Utils();
            _student = (Student)std;
            _validate = new Validate();
            InitializeComponent();
        }

        private void btn_PassConfrim_Click(object sender, EventArgs e)
        {

            String sp_Name = "sp_ChangePassword";
            string[] param = { "std_Id", "std_Pass" };
            string[] val = { _student.ID.ToString(), txt_ChangePass.Text };

            if (!_validate.checkEmpty(val))
            {
                _sql.ProcessDB(sp_Name, param, val);
                MessageBox.Show("Password Changed");
            }
            else if (!(txt_ChangePass.Text.Equals(txt_ChangePassConfirm)))
            {
                MessageBox.Show("Passwords Not Same!");
            }
            else
            {
                MessageBox.Show("Please Fill the fields");
            }

            
        }

        private void btn_EmailConfrim_Click(object sender, EventArgs e)
        {
            String sp_Name = "sp_ChangeEmail";
            string[] param = { "std_Id", "std_Email" };
            string[] val = { _student.ID.ToString(), txt_ChangeEmail.Text };

            if (!_validate.checkEmpty(val))
            {
                _sql.ProcessDB(sp_Name, param, val);
                MessageBox.Show("Email Changed");
            }
            else
            {
                MessageBox.Show("Please Fill the fields");
            }
        }

        private void txt_ChangeEmail_OnValueChanged(object sender, EventArgs e)
        {
            
            if (_validate.IsValidEmail(txt_ChangeEmail.Text))
            {
                _utils.Revert_FieldColor(txt_ChangeEmail);
            }
            else
            {
                txt_ChangeEmail.Focus();
                _utils.Change_FieldColor(txt_ChangeEmail);
            }
        }

        private void txt_ChangePassConfirm_OnValueChanged(object sender, EventArgs e)
        {
            txt_ChangePassConfirm.isPassword = true;
        }
        private void txt_ChangePass_OnValueChanged(object sender, EventArgs e)
        {
            txt_ChangePass.isPassword = true;
        }
    }
}
