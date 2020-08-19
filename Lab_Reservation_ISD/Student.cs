using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    class Student
    {
        public int ID { get; set; }
        public String RegID { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public string Status { get; set; }
        public String Contact { get; set; }
        public byte Image { get; set; }

        public Student()
        {

        }

        public Student(string id, string fName, string lName, string email, string password, string contact)
        {
            RegID = id;
            FName = fName;
            LName = lName;
            Email = email;
            Password = password;
            Contact = contact;

        }
    }
}
