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
        List<Event> events = new List<Event>();

        List<Ticket> ticket = new List<Ticket>();

        List<VIPTicket> vipTicket = new List<VIPTicket>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //2 Event objects
            Event event1 = new Event("Oasis Croke Park",new DateTime(2025, 06, 20), TypeOfEvent.Music );
            Event event2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), TypeOfEvent.Music);

            //2 Ticket objects
            Ticket ticket1 = new Ticket("Early bird", 100m, 100);
            Ticket ticket2 = new Ticket("Platinum", 150m, 100);

            //2 VIP Ticket objects
            VIPTicket vipTicket1 = new VIPTicket("Ticket and Hotel Package", 150m, 100m, "4* Hotel", 100);
            VIPTicket vipTicket2 = new VIPTicket("Weekend Ticket", 200m, 100m, "With Camping", 100);

            
        }
    }
}
