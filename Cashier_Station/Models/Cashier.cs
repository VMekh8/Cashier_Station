using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Cashier
    {
        public List<Ticket> tickets = new List<Ticket>();
        
        public int Balance { get; set; }
    }
}
