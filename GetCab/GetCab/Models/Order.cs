using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCab.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public string FromCoordinate { get; set; }
        public string ToCoordinates { get; set; }
        public DateTime EstimatedCarArrivalTime { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
