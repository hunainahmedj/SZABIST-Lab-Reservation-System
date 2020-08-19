using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace Lab_Reservation_ISD
{
    class Utils
    {

        public void Change_UserControl(UserControl control, Panel pannel)
        {
            UserControl _userControl = control;
            pannel.Controls.Clear();
            pannel.Controls.Add(_userControl);
            _userControl.Show();

        }

        public void Change_UserControl(UserControl control, Panel pannel, int top, int left)
        {
            var UserControl = control;
            pannel.Controls.Clear();
            pannel.Controls.Add(UserControl);
            UserControl.Show();
            UserControl.Top = top;
            UserControl.Left = left;

        }

        public void Add_UserControl(UserControl control, Panel panel)
        {
            var UserControl = control;
            panel.Controls.Add(UserControl);
            UserControl.Show();
        }

        public void Load_DataGrid(BunifuCustomDataGrid dgv, SQLConnection sql, string sp_Name)
        {
            dgv.DataSource = sql.GetViews(sp_Name);
        }

        //Admin
        public void Load_DataGrid(DataGridView dgv, SqlMng sql, string sp_Name)
        {
            dgv.DataSource = sql.getTable(sp_Name);
        }

        public void Change_FieldColor(BunifuMaterialTextbox txt)
        {
            txt.LineIdleColor = MyColor.orangeRed;
            txt.LineMouseHoverColor = MyColor.orangeRed;
            txt.LineFocusedColor = MyColor.orangeRed;
        }

        public void Revert_FieldColor(BunifuMaterialTextbox txt)
        {
            txt.LineIdleColor = MyColor.bluePrimary;
            txt.LineMouseHoverColor = MyColor.blueHover;
            txt.LineFocusedColor = MyColor.blueFocused;
        }

        public static byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream mStream = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(mStream);
            }
        }

        public Image DisplayImage(string spName, string[] param, object[] value)
        {
            Type rowType;
            byte[] storedImage = { };
            DataTable dt = new SQLConnection().GetViews(spName, param, value);
            foreach (DataRow row in dt.Rows)
            {
                rowType = row["img"].GetType();
                if (!rowType.FullName.Equals("System.DBNull"))
                {
                    storedImage = (byte[])row["img"];
                }
            }
            return storedImage.Length <= 0 ? null : byteArrayToImage(storedImage);
        }

        public void UploadImage(string spName, string[] param, int ID)
        {
            OpenFileDialog _dialog = new OpenFileDialog();

            if (_dialog.ShowDialog() == DialogResult.OK)
            {
                Image UserImage = Image.FromFile(_dialog.FileName);
                byte[] byteImage = imgToByteArray(UserImage);
                object[] value = { ID, byteImage};
                new SQLConnection().ProcessDB(spName, param, value);
            }
        }

        public void SetDisplay(PictureBox pictureBox, Image img)
        {
            pictureBox.Image = img;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
       
    }
}
