using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCab.Models
{
    class Ride
    {
        public int Id { get; set; }
        public int Driver_Id { get; set; }
        public DateTime CarArrivalTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Order_Id { get; set; }
    }
}
