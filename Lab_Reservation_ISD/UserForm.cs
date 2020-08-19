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
    public partial class UserForm : Form
    {
        private SqlMng SqlMng; 
        public UserForm()
        {
            InitializeComponent();
        }
        //User
        private void button1_Click(object sender, EventArgs e)
        {
            
            Entry entry = new Entry();
            entry.Show();
            this.Hide();
        }

        //Admin
        private void button2_Click(object sender, EventArgs e)
        {
            SqlMng = SqlMng.GetObject();
            LoginAdmin loginAdmin = new LoginAdmin(SqlMng);
            loginAdmin.Show();
            this.Hide();
        }
    }
}
