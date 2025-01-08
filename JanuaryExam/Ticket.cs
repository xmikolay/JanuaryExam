﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    internal class Ticket
    {
        //Shorthand Properties for ticket class
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }

        public override string ToString()
        {
            return $"{Name} - {Price:c} [AVAILABLE - {AvailableTickets}]";
        }
    }
}
