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
    /// Interaction logic for W_bookingDetails.xaml
    /// </summary>
    public partial class W_CustomerDetails : Window
    {
        public Bicycle BicycleInfo { get; set; }

        public W_CustomerDetails()
        {
            InitializeComponent();

            //StartClock();
        }

        public W_CustomerDetails(Bicycle bicycle)
        {
            InitializeComponent();

            BicycleInfo = bicycle;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //var sortListBox = App._customers.OrderBy(c => c.firstName);   // Sorting Listbox of Customers by name
            //Lbx_Customers.ItemsSource = sortListBox;

            Lbx_Customers.ItemsSource = App._customers;

        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Owner.Visibility = Visibility.Visible;
        }



        private void Tbx_FilterId_Customer_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from c in App._customers where c.firstName.ToLower().Contains(filter) select c;
            Lbx_Customers.ItemsSource = lst;
        }

        public void Btn_Add_Customer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer { firstName = "edit", lastName = "edit", customerId = Math.Abs(Guid.NewGuid().GetHashCode()).ToString(), telephone = "edit", idNumber = "edit", zipCode = "edit" };
            App._customers.Add(customer);
            Lbx_Customers.SelectedItem = customer;
            Lbx_Customers.ScrollIntoView(customer);
        }


        private void Btn_Del_Customer_Click(object sender, RoutedEventArgs e)
        {
            var item = Lbx_Customers.SelectedItem;   // One selected customer with its properties
            if (item == null)
            {
                MessageBox.Show("Please select a customer from the list to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var deleteItem = item as Customer;
            var warn = MessageBox.Show($"Are you sure you want to delete {deleteItem.firstName} {deleteItem.lastName} ?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (warn == MessageBoxResult.OK)
            {
                App._customers.Remove(deleteItem);
            }
        }        
        
    }
}
