using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Rent_a_Bicycle_App
{
    /// <summary>
    /// Interaction logic for W_return.xaml
    /// </summary>
    public partial class W_return : Window
    {
        ObservableCollection<Customer> customersWithHiredBikes = new ObservableCollection<Customer>();  // List for customers with Hired bicycles

        public W_return()
        {
            InitializeComponent();

            StartClock();
        }

        public void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TickEvent;
            timer.Start();

        }

        private void TickEvent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Tbk_Time.Text = DateTime.Now.ToString(@"HH\:mm");
            Tbk_Day.Text = DateTime.Now.ToString("ddd,");               //Add textblock for comma sign after day.
            Tbk_Date.Text = DateTime.Now.ToString("MMM dd, yyyy");      // MMMM in capital letters for Month
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lbx_Bookings.ItemsSource = App._bookings;

            customersWithHiredBikes = GetCustomers();
            Lbx_Customers.ItemsSource = customersWithHiredBikes;
        }


            private void Tbx_SearchByBicycleId_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from b in App._bookings where (b.bicycleId.ToLower().Contains(filter) || b.bookingId.ToLower().Contains(filter) || b.customerId.ToLower().Contains(filter)) select b;

            //Lbx_Customers.ItemsSource = lst;
        }


        private void Tbx_SearchByCustomerName_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();   // Search Text by Customer name
            //customersWithHiredBikes = (from c in customersWithHiredBikes where c.lastName.ToLower().Contains(filter) select c);   //Get Customer Id from Customer list
            Lbx_Customers.ItemsSource = customersWithHiredBikes;          

            //Lbx_Customers.ItemsSource = lst;
        }

        private ObservableCollection<Customer> GetCustomers()
        {
            List<Booking> bookings = (from b in App._bookings where b.status == "Hired" select b).ToList();
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();  // Customers list for - Hired Bikes
           

            foreach (Booking booking in bookings)           
            {
                Customer customer = (from c in App._customers where c.customerId == booking.customerId select c).Single();
                customers.Add(customer);                
            }

            return customers;
        }

        private void Tbx_NoOfHours_TextChanged(object sender, TextChangedEventArgs e)
        {
            int noOfHours = int.Parse(Tbx_NoOfHours.Text);
            Tbx_SubTotal.Text = (noOfHours * int.Parse(Tbx_Tariff.Text)).ToString();
            Tbx_Total.Text = (int.Parse(Tbx_SubTotal.Text) - int.Parse(Tbx_DepositPaidAmount.Text)).ToString();
                  

        }


    }
}
