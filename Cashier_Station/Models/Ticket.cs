using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        
        public Route routeId { get; set; }

        public int Price { get; set; }

        public DateTime DateBuy { get; set; }

        public bool IsActive { get; set; }

    }
}
