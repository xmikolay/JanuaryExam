using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    public class Ticket
    {
        //Shorthand Properties for ticket class
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableTickets { get; set; }

        //Constructor that just assigns all the properties
        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTickets;
        }

        //To string to display tickets
        public override string ToString()
        {
            return $"{Name} - {Price:c} [AVAILABLE - {AvailableTickets}]";
        }
    }
}
