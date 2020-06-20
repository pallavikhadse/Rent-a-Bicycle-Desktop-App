using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Rent_a_Bicycle_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // FOR Bicycles
        public static ObservableCollection<Bicycle> _bicycles;

        public static List<string> _status = new List<string> {"Available", "Hired"}; //check wrt. to bicycles.xml file.
        public static List<string> _categories = new List<string> { "M", "F", "CH" };    // Populate in CoBx_Categories_Add in W_rent.xaml file.  

        //public static HashSet<string> _gears = new HashSet<string>();   // Collection with distinct values of gear

        //public static List<string> _tariff = new List<string>();

        Random rnd = new Random(Guid.NewGuid().GetHashCode());

        // FOR Customers
        public static ObservableCollection<Customer> _customers;  

        // FOR Booking Info
        public static ObservableCollection<Booking> _bookings;
        

        public App() { }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            // FOR Collection of Bicycles from Storage
            _bicycles = MY_Storage.ReadXml<ObservableCollection<Bicycle>>("bicycles.xml");
            //_bicycles = _bicycles.OrderBy(b => b.brandName);


            if (_bicycles == null)
            {
                _bicycles = new ObservableCollection<Bicycle>();
            }
            

            // FOR Collection of Customers from Storage
            _customers = MY_Storage.ReadXml<ObservableCollection<Customer>>("customers.xml");

            if(_customers == null)
            {
                _customers = new ObservableCollection<Customer>();
            }

            // FOR Collection of Bookings from Storage
            _bookings = MY_Storage.ReadXml<ObservableCollection<Booking>>("bookings.xml");

            if (_bookings == null)
            {
                _bookings = new ObservableCollection<Booking>();
            }
        }

        private void App_Exit(object sender, ExitEventArgs e)
        {
            MY_Storage.WriteXml<ObservableCollection<Bicycle>>(_bicycles, "bicycles.xml");

            MY_Storage.WriteXml<ObservableCollection<Customer>>(_customers, "customers.xml");

            MY_Storage.WriteXml<ObservableCollection<Booking>>(_bookings, "bookings.xml");
        }

    }

    
}
