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
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString();
        }

        private void hBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void hBtn_CopyRight_Click(object sender, EventArgs e)
        {
            Copyright _copyright = new Copyright();
            _copyright.Show();
        }
    }
}
