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
    public partial class ReservationForm : UserControl
    {
        SQLConnection _sql;
        Student _student;
        Utils _utils;
        Reservation _reservation;

        public ReservationForm(Object std)
        {
            _student = (Student)std;
            _sql = new SQLConnection();
            _utils = new Utils();

            InitializeComponent();
            _utils.Load_DataGrid(dgv_Reservations, _sql, "Get_Reservations");
            Initialize_Cmb();
        }



        private bool CheckReservation()
        {
            bool flag = false;

            string ReserveCheckSp = "Check_Reservation";
            string[] param = { "Date", "Time", "Device" };
            object[] value = { tp_Date.Value.ToShortDateString(), cmb_TimeSlot.SelectedIndex + 1, cmb_Device.SelectedIndex + 1 };


            _reservation = _sql.checkReservation(ReserveCheckSp, param, value);

            if (_reservation.Date.ToShortDateString() == tp_Date.Value.ToShortDateString()
                && _reservation.Slot == (cmb_TimeSlot.SelectedIndex + 1)
                && _reservation.Device == (cmb_Device.SelectedIndex + 1))
            {
                flag = true;
                MessageBox.Show("Slot is already Reserverd");
            }
            else
            {
                string spName = "Reservation_Count_Approved";
                int id = _student.ID;

                string[] _param = { "std_ID" };
                object[] _value = { id };

                int reserverCount = _sql.Get_Count(spName, _param, _value);
                if (reserverCount > 2)
                {
                    MessageBox.Show("You already have 2 reservations");
                    flag = true;

                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }



        private void btn_MakeReserve_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Now;
            int DateCompare = DateTime.Compare(tp_Date.Value, Date);
            int ReservationCount = _sql.Get_Count("Count_Reservations", new string[] { "std_Id" }, new string[] { _student.ID.ToString() });

            if (CheckReservation() == true)
            {
                MessageBox.Show("Already Reserved");

            }
            else if (DateCompare < 0)
            {
                MessageBox.Show("Select a valid Date");
            }
            else if (ReservationCount >= 2)
            {
                MessageBox.Show("You already have 2 reservations");
            }
            else
            {
                string spName = "Insert_Reservation";
                string[] param = { "Date", "std_ID", "d_ID", "s_ID" };
                object[] value = { tp_Date.Value.ToShortDateString(), _student.ID, cmb_Device.SelectedValue, cmb_TimeSlot.SelectedValue };
                _sql.ProcessDB(spName, param, value);
                dgv_Reservations.Refresh();
                _utils.Load_DataGrid(dgv_Reservations, _sql, "Get_Reservations");
            }

        }

        private void Initialize_Cmb()
        {
            //Loading Devices
            cmb_Device.DataSource = _sql.GetViews("Load_Devices");
            cmb_Device.ValueMember = "d_id";
            cmb_Device.DisplayMember = "d_name";

            //Loading Slots
            cmb_TimeSlot.DataSource = _sql.GetViews("Load_Slots");
            cmb_TimeSlot.ValueMember = "s_id";
            cmb_TimeSlot.DisplayMember = "s_name";
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
