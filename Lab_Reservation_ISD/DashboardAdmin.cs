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
    public partial class DashboardAdmin : Form
    {
        private SqlMng _sqlMng;
        private Utils _utils;
        private Admin _admin;
        string dash = "Dashboard";
        public DashboardAdmin(SqlMng mng, Admin admin)
        {

            InitializeComponent();

            lbl_Header.Text = dash + " - " + "Home";
            

            _sqlMng = mng;
            _admin = admin;
            _utils = new Utils();

            _utils.Change_UserControl(new HomeAdmin(_admin), p_DashControl);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            CPending cp = new CPending(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(cp);
            cp.Show();
        }

        private void btn_Timeslots_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Time SLots";
            TimeSlots TS = new TimeSlots(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(TS);
            TS.Show();
        }

        private void btn_Devices_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Devices";
            UDevice UD = new UDevice(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(UD);
            UD.Show();

        }

        private void btn_UserRequests_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "User Requests";
            CUserReq UR = new CUserReq(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(UR);
            UR.Show();

        }

        private void btn_PendingRequests_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Pending Reservations";
            CPending cp = new CPending(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(cp);
            cp.Show();
        }

        private void btn_AcceptedReserves_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Accepted Reservations";
            AcceptedReservations AR = new AcceptedReservations(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(AR);
            AR.Show();
        }

        private void btn_AdminRequests_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Admin Requests";
            AdminReq AR = new AdminReq(_sqlMng);
            p_DashControl.Controls.Clear();
            p_DashControl.Controls.Add(AR);
            AR.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            user.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_C_Settings_Click(object sender, EventArgs e)
        {
            lbl_Header.Text = dash + " - " + "Account Settings";
            _utils.Change_UserControl(new AccountSettingsControl(_sqlMng, _admin),p_DashControl);
        }

        private void nBtn_LogOut_Click(object sender, EventArgs e)
        {
            _admin = null;
            LoginAdmin _loginAdmin = new LoginAdmin(_sqlMng);
            _loginAdmin.Show();
            this.Hide();

        }

        private void nBtn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Home_1_Click(object sender, EventArgs e)
        {
            _utils.Change_UserControl(new HomeAdmin(_admin), p_DashControl);
        }
    }
}
