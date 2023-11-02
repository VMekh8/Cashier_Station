using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class InterMediateRoute : Route
    {
        public string NameStation { get; set; }

        public int  DistanceFromStart { get; set; }
        public int DistanceFromEnd { get; set;}
        public DateTime ArrivalTime { get; set; }
    }
}
