using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    public class Admin
    {
        public int a_id { get; set; }
        public string a_name { get; set; }
        public string a_email { get; set; }
        public string a_pass { get; set; }
        public char a_status { get; set; }

        public Admin()
        {

        }

        public Admin(int a_id, string a_name, string a_email, string a_pass, char a_status) : this(a_id)
        {
            this.a_name = a_name;
            this.a_email = a_email;
            this.a_pass = a_pass;
            this.a_status = a_status;
        }

        public Admin(string n, string e, string p)
        {
            this.a_name = n;
            this.a_email = e;
            this.a_pass = p;
        }

        public Admin(int i)
        {
            this.a_id = i;
        }

        public Admin(int i, char s)
        {
            this.a_id = i;
            this.a_status = s;
        }

        public Admin(string e, string p)
        {
            this.a_email = e;
            this.a_pass = p;
        }
    }
}
