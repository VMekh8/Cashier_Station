using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Route
    {
        public int IDRoute { get; set; }
        public string Name { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public DateTime DateofStart { get; set; }
        public DateTime DateofEnd { get; set;}
        public int SeatsNumber { get; set; }
    }
}
