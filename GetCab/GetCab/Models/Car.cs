using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCab.Models
{
    class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string License_plate { get; set; }
        public int Driver_Id { get; set; }
    }
}
