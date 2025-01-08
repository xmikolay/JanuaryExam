using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    internal class Event : IComparable
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public enum EventType { Music, Comedy, Theatre}

        public Event(string name, DateTime eventDate, List<Ticket> tickets)
        {
            Name = name;
            EventDate = eventDate;
            Tickets = tickets;
        }

        //IComparable interface
        public int CompareTo(object obj)
        {
            Event that = obj as Event;

            return this.EventDate.CompareTo(that.EventDate); //Comparing one event date to another
        }
    }
}
