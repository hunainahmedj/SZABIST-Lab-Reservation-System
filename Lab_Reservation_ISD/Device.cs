using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    class Device
    {
        public int d_id { get; set; }
        public string d_name { get; set; }


        public Device(string n)
        {
            this.d_name = n;
        }

    }
}
