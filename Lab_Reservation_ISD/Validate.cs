using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    class Validate
    {
        Utils _utils = new Utils();
        SQLConnection _sql = new SQLConnection();

        public bool checkEmpty(string[] fields)
        {

            bool emptyFlag = false;
            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i] == "")
                {
                    emptyFlag = true;
                    break;
                }
            }

            return emptyFlag;
        }

        public bool checkEmpty(BunifuMaterialTextbox[] fields)
        {

            bool emptyFlag = false;
            for (int i = 0; i < fields.Length; i++)
            {
                if (fields[i].Text == "")
                {
                    _utils.Change_FieldColor(fields[i]);
                    emptyFlag = true;
                }
            }

            return emptyFlag;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPhone(string phone)
        {
            
            if (Regex.Matches(phone, @"[a-zA-Z]").Count <= 0 && phone.Length == 11)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            if (password.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IdPresent(string Id)
        {
            string sp_Name = "Check_Id";
            string[] param = { "std_Id" };
            string[] value = { Id };

            if (_sql.Get_Count(sp_Name, param, value) >= 1)
            {
                return true;
            }

            return false;
        }

        public bool EmailPresent(string Email)
        {
            string sp_Name = "sp_CheckAdminEmail";
            string[] param = { "a_email" };
            string[] value = { Email };

            if (_sql.Get_Count(sp_Name, param, value) >= 1)
            {
                return true;
            }

            return false;
        }
    }
}
