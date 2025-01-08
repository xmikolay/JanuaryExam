using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JanuaryExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Lists to hold event objects and ticket objects (vip included)
        List<Event> events = new List<Event>();

        List<Ticket> ticket = new List<Ticket>();

        //List<VIPTicket> vipTicket = new List<VIPTicket>();

        List<Event> searchEvent;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //2 Event objects
            Event event1 = new Event("Oasis Croke Park",new DateTime(2025, 06, 20), TypeOfEvent.Music );
            Event event2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), TypeOfEvent.Music);
            events.Add(event1);
            events.Add(event2);
            //events.Add(event2); //Testing to see if events get sorted
            //events.Add(event1);
            events.Sort();

            //2 Ticket objects
            Ticket ticket1 = new Ticket("Early bird", 100m, 100);
            Ticket ticket2 = new Ticket("Platinum", 150m, 100);
            ticket.Add(ticket1);
            ticket.Add(ticket2);

            //2 VIP Ticket objects
            VIPTicket vipTicket1 = new VIPTicket("Ticket and Hotel Package", 150m, 100m, "4* Hotel", 100);
            VIPTicket vipTicket2 = new VIPTicket("Weekend Ticket", 200m, 100m, "With Camping", 100);
            ticket.Add(vipTicket1);
            ticket.Add(vipTicket2);
            
            lbxEvents.ItemsSource = events; //Displaying events in the list box
        }

        private void lbxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Event selected = lbxEvents.SelectedItem as Event;

            if (selected != null)
            {
                lbxTickets.ItemsSource = ticket; //Temporary setting of ticket list box to all of the tickets available
            }
        }

        //Attempted Q1(k)
        
        //private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string searchTerm = tbxSearch.Text;

        //    if (string.IsNullOrEmpty(searchTerm))
        //        UpdateDisplay(events);
        //    else
        //    { 
        //        searchEvent = FilterEvents(searchTerm);

        //    }
        //}

        //private void UpdateDisplay(List<Event> events)
        //{
        //    lbxEvents.ItemsSource = null;
        //    lbxTickets.ItemsSource = null;

        //    lbxEvents.ItemsSource = FilterEvents(events);
        //}

        //private List<Event> FilterEvents(List<Event> events, string searchTerm)
        //{
        //    List<Event> filteredEvent = new List<Event>();

        //    foreach (Event item in events)
        //    {
        //        if(item.Name.ToLower().Contains(searchTerm.ToLower()))
        //            filteredEvent.Add(item);
        //    }
        //    return filteredEvent;
        //}
    }
}
