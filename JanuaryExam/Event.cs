using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace JanuaryExam
{
    //Create enum here
    public enum TypeOfEvent { Music, Comedy, Theatre }

    internal class Event : IComparable
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public TypeOfEvent EventType { get; set; }

        public Event(string name, DateTime eventDate, TypeOfEvent eventType)
        {
            Name = name;
            EventDate = eventDate;
            EventType = eventType;
        }

        //IComparable interface
        public int CompareTo(object obj)
        {
            Event that = obj as Event;

            return this.EventDate.CompareTo(that.EventDate); //Comparing one event date to another
        }
    }
}
