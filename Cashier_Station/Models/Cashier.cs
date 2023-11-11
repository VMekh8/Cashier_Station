using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Cashier
    {
        [Key]
        public int Id { get; set; }

        public List<Ticket> Tickets { get; set; }
        
        public int Balance { get; set; }
    }
}
