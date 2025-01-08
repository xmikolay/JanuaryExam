using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    internal class VIPTicket : Ticket
    {
        public string AdditionalExtras { get; set; }
        public decimal AdditionalCost { get; set; }
   
        public VIPTicket(string name, decimal price, decimal additionalCost, string additionalExtras, int availableTickets) 
            : base(name, price, availableTickets) //base calls the Ticket class for name price and available tickets
        { 

        }
    }
}
