using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    class Slot
    {
        public int s_id { get; set; }
        public string s_name { get; set; }



        public Slot(string n)
        {
            this.s_name = n;
        }

    }
}
