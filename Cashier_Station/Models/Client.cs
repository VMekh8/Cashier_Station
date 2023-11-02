﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Client : Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Ticket idTicketForBuy { get; set; }
    }
}