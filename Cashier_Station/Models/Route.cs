using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Route
    {
        [Key]
        public int ID { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public DateTime DateofStart { get; set; }
        public DateTime DateofEnd { get; set;}
        public int SeatsNumber { get; set; }
        public int TransportId { get; set; }
    }
}
