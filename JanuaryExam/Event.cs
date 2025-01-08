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

    public class Event : IComparable
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

        public override string ToString()
        {
            return $"{Name} - {EventDate}";
        }

        //Trying to make a method to set random tickets for both events, couldnt figure it out

        //public void AssignTicket()
        //{
        //    Random r = new Random();

            

        //    for (int i = 0; i < Tickets.Count; i++)
        //    {
        //        Ticket t = Tickets[i];
        //    }
        //}
    }
}
