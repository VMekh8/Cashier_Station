﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashier_Station.Models
{
    public class Transport
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
