using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Reservation_ISD
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int Slot { get; set; }
        public int Device { get; set; }
    }
}
