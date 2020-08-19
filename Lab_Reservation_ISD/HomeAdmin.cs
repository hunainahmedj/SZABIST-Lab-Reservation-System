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
    public partial class HomeAdmin : UserControl
    {

        private Admin _admin;
        private Utils _utils;

        public HomeAdmin(Admin admin)
        {
            InitializeComponent();
            _admin = admin;
            _utils = new Utils();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            lbl_ProfID.Text = lbl_ProfID.Text + _admin.a_id.ToString();
            lbl_ProfName.Text = lbl_ProfName.Text + _admin.a_name.ToString();
            lbl_ProfDesig.Text = lbl_ProfDesig.Text + "Admin";

            //Image Stuff
            Image UserImage = _utils.DisplayImage("sp_GetAdminImage", new string[] { "a_ID" }, new object[] { _admin.a_id });
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

        private void btn_DisplayUser_Click(object sender, EventArgs e)
        {
            _utils.UploadImage("sp_InsertAdminImage", new string[] { "a_ID", "a_image" }, _admin.a_id);
            _utils.SetDisplay(pic_UserDisplay, _utils.DisplayImage("sp_GetAdminImage", new string[] { "a_ID" }, new object[] { _admin.a_id }));
            btn_ImageUpload.Visible = false;
        }
    }
}
