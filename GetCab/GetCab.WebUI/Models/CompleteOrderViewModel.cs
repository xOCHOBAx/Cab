using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetCab.WebUI.Models
{
    public class CompleteOrderViewModel
    {
        public int Order_Id { get; set; }
        public int User_Id { get; set; }
        public string FromCoordinate { get; set; }
        public string ToCoordinates { get; set; }
        public DateTime EstimatedCarArrivalTime { get; set; }
        public DateTime OrderTime { get; set; }
        public int Ride_Id { get; set; }
        public int Driver_Id { get; set; }
        public DateTime CarArrivalTime { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}