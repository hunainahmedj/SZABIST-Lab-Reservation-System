using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Reservation_ISD
{
    public partial class Home : UserControl
    {

        Student _student;
        SQLConnection _sql;
        DataTable ReservationsDT;
        Utils _utils;

        public Home(Object std)
        {
            _student = (Student)std;
            _sql = new SQLConnection();
            _utils = new Utils();

            InitializeComponent();

            GetReservations();
            InitLabels();
        }

        public void GetReservations()
        {
            ReservationsDT = _sql.GetViews("My_Reservation", new string[] { "std_id" }, new string[] { _student.ID.ToString() });
        }

        public void InitLabels()
        {
            string dates = "";
            string status = "";

            lbl_ProfID.Text = lbl_ProfID.Text + _student.RegID.ToString();
            lbl_ProfName.Text = lbl_ProfName.Text + _student.FName + " " + _student.LName;
            lbl_ProfDesig.Text = lbl_ProfDesig.Text + "Student";
            lbl_ReservationNo.Text = lbl_ReservationNo.Text + _sql.Get_Count("Count_Reservations", new string[] { "std_Id" }, new string[] { _student.ID.ToString() }).ToString();

            foreach (DataRow row in ReservationsDT.Rows)
            {
                dates = dates + " & " + row["r_date"].ToString();
                status = status + " & " + row["r_status"].ToString();
            }

            lbl_ReservationDates.Text = lbl_ReservationDates.Text + " " + dates;
            lbl_ReservationStatus.Text = lbl_ReservationStatus.Text + " " + status;
        }

        private void btn_ImageUpload_Click(object sender, EventArgs e)
        {
            _utils.UploadImage("sp_InsertStudentImag", new string[] { "std_ID", "std_image" }, _student.ID );
            _utils.SetDisplay(pic_UserDisplay, _utils.DisplayImage("sp_GetStudentFull", new string[] { "std_ID" }, new object[] { _student.ID }));
            btn_ImageUpload.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Image UserImage = _utils.DisplayImage("sp_GetStudentFull", new string[] { "std_ID" }, new object[] { _student.ID });
            if (UserImage == null)
            {
                btn_ImageUpload.Visible = true;
            }
            else
            {
                _utils.SetDisplay(pic_UserDisplay, UserImage);
                btn_ImageUpload.Visible = false;
            }
            
        }
    }
}
