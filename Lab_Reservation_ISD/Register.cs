using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Lab_Reservation_ISD
{
    public partial class Register : UserControl
    {
        SQLConnection sql;
        Validate vl;
        Utils _utils;

        string sp_Name;
        string[] param;
        string[] value;
        BunifuMaterialTextbox[] fields;

        public Register()
        {
            _utils = new Utils();
            sql = new SQLConnection();
            vl = new Validate();
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            InitVariables();
        
            bool isValidEmail = vl.IsValidEmail(txt_Email.Text);
            bool emptyFlag = vl.checkEmpty(fields);
            bool isValidPhone = vl.IsValidPhone(txt_Phone.Text);
            bool isValidPass = vl.IsValidPassword(txt_Pass.Text);
            bool IdPresent = vl.IdPresent(txt_Id.Text);

            if (emptyFlag == false && isValidEmail && isValidPhone && IdPresent == false && isValidPass)
            {
                sql.ProcessDB(sp_Name, param, value);
                MessageBox.Show("You are Registered!");
            }
            else if (IdPresent)
            {
                MessageBox.Show("You are already Registered");
            }
            else if (!isValidPass)
            {
                MessageBox.Show("Password should be more then 6 characters!");
            }
            

        }

        private void InitVariables()
        {
            sp_Name = "Student_SignUp";

             
            param = new[] { "@std_regId",
                            "std_fName",
                            "std_lName",
                            "std_email",
                            "std_pass",
                            "std_contact" };

            value = new[] { txt_Id.Text,
                            txt_FName.Text,
                            txt_LName.Text,
                            txt_Email.Text,
                            txt_Pass.Text,
                            txt_Phone.Text };


            fields = new[] { txt_Id,
                             txt_FName,
                             txt_LName,
                             txt_Email,
                             txt_Pass,
                             txt_Phone };
        }

        private void txt_Email_OnValueChanged(object sender, EventArgs e)
        {
            bool isValidEmail = vl.IsValidEmail(txt_Email.Text);
            if (isValidEmail)
            {
                _utils.Revert_FieldColor(txt_Email);
            }
            else
            {
                txt_Email.Focus();
                _utils.Change_FieldColor(txt_Email);
            }
        }

        private void txt_Phone_OnValueChanged(object sender, EventArgs e)
        {
            bool isValidPhone = vl.IsValidPhone(txt_Phone.Text);
            if (isValidPhone)
            {
                _utils.Revert_FieldColor(txt_Phone);
            }
            else
            {
                txt_Phone.Focus();
                _utils.Change_FieldColor(txt_Phone);
            }
        }

        private void txt_Pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_Pass.isPassword = true;
        }
    }
}
