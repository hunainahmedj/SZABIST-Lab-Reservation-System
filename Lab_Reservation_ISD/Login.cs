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
    public partial class Login : UserControl
    {
        SQLConnection _sql;
        Student _student;
        Validate _validate;
        
        public Login()
        {
            _validate = new Validate();
            _sql = new SQLConnection();

            InitializeComponent();
            txt_Id.LineIdleColor = MyColor.bluePrimary;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string[] param = { "std_ID", "std_pass" };
            string[] value = { txt_Id.Text, txt_Pass.Text };
            string spName = "Student_Login";
            bool emptyFlag = _validate.checkEmpty(value);

            if (!emptyFlag)
            {
                try
                {
                    _student = _sql.Login(spName, param, value);
                }
                catch
                {

                }

                if (_student != null && _student.ID != 0 && _student.Status == "A")
                {
                    Dashboard _dashboard = new Dashboard(_student);
                    Entry _entery = new Entry();
                    _dashboard.Show();
                    this.TopLevelControl.Hide();

                }
                else if (_student.Status == "P")
                {
                    MessageBox.Show("Your Approval is still pending");
                }
                else
                {
                    MessageBox.Show("ID or Password do not match!");
                }

            }
            else
            {
                MessageBox.Show("All Fields are required!");
            }

        }

        private void txt_Pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_Pass.isPassword = true;
        }
    }
}
