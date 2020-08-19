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
    public partial class Dashboard : Form
    {

        Student _student;
        Utils _utils;
        SQLConnection _sql;

        string dash = "Dashboard";
        public Dashboard(Object std)
        {
            _student = (Student)std;
            _utils = new Utils();
            _sql = new SQLConnection();

            InitializeComponent();

            _utils.Change_UserControl(new Home(_student), p_DashControl);

            lbl_Header.Text = dash + " - " + "Home";
        }

        

        private void nBtn_Home_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Home";
            _utils.Change_UserControl(new Home(_student), p_DashControl);

        }

        private void nBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void nBtn_Reserve_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Request Slots";
            _utils.Change_UserControl(new ReservationForm(_student), p_DashControl);
        }

        private void nBtn_Cancel_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Cancel Reservation";
            _utils.Change_UserControl(new CancelFrom(_student), p_DashControl);
        }

        private void nBtn_Settings_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Settings";
            _utils.Change_UserControl(new SettingsForm(_student), p_DashControl);
        }

        private void nBtn_LogOut_Click(object sender, EventArgs e)
        {
            _student = null;
            this.TopLevelControl.Hide();
            new Entry().Show();
        }
    }
}
