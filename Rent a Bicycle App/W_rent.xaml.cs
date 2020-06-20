using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
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
    /// Interaction logic for W_rent.xaml
    /// </summary>
    public partial class W_rent : Window
    {
        
        string language;
        string buttonType; // for Category button selection
        private bool firstTime;

        public W_rent()
        {
            language = Properties.Settings.Default.language;
            CultureInfo.CurrentCulture = new CultureInfo(language);
            CultureInfo.CurrentUICulture = new CultureInfo(language);       

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
            Lbx_Bicycles.ItemsSource = App._bicycles;
            //var sortListBox = App._bicycles.OrderBy(b => b.brandName);     // Sorting Listbox of Bicycles by brandName
            //Lbx_Bicycles.ItemsSource = sortListBox;

            Lbx_Customers.ItemsSource = App._customers;
            

            //CoBx_Categories.ItemsSource = App._categories;                
            CoBx_Categories_Add.ItemsSource = App._categories;           // ComboBox on right of the window         

                  

            CoBx_Languages.ItemsSource = new List<string> { "en English", "de Deutsch" };
        }

        private void Tbx_filter_TextChanged(object sender, TextChangedEventArgs e)
        {

            var filter = (sender as TextBox).Text.ToLower();
            var filteredBicycles = new object();
            string category;

            //First determine which button is clicked and populate local string variable category
            switch (buttonType)
            {
                case "M":
                    category = "M";
                    break;
                case "F":
                    category = "F";
                    break;
                case "CH":
                    category = "CH";
                    break;
                default:
                    category = "";
                    break;
            }

            // then determine if textbox has any value. If textbox has value, then populate local variable filteredBicycles
            if (filter == "")
            {
                filteredBicycles = from b in App._bicycles where b.category == category select b;
            }
            else
            {
                if (category.Equals(""))
                {
                    filteredBicycles = from b in App._bicycles where b.status.ToLower().Contains(filter) || b.gear.ToString().Contains(filter) || b.size.ToString().Contains(filter) || b.brandName.ToLower().Contains(filter) select b;
                } else 
                { 
                filteredBicycles =  from b in App._bicycles where b.category == category && (b.status.ToLower().Contains(filter) || b.gear.ToString().Contains(filter) || b.size.ToString().Contains(filter) || b.brandName.ToLower().Contains(filter)) select b;                
                }
            }

            Lbx_Bicycles.ItemsSource = (IEnumerable<Bicycle>) filteredBicycles;
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Bicycle bicycle = new Bicycle { brandName = "edit", status = "edit", size = "edit", gear = Int32.Parse("0"), tariff = Int32.Parse("0"), bicycleId = Math.Abs(Guid.NewGuid().GetHashCode()).ToString() };
            App._bicycles.Add(bicycle);
            Lbx_Bicycles.SelectedItem = bicycle;
            Lbx_Bicycles.ScrollIntoView(bicycle);

        }

        private void Btn_Del_Click(object sender, RoutedEventArgs e)
        {
            var itm = Lbx_Bicycles.SelectedItem;   // One selected bicycle with its properties
            if (itm == null)
            {
                MessageBox.Show("Please select a bicycle from the list to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var deleteItem = itm as Bicycle;
            var warn = MessageBox.Show($"Are you sure you want to delete {deleteItem.brandName} {deleteItem.category} {deleteItem.size} {deleteItem.gear} ?", "Warning", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (warn == MessageBoxResult.OK)
            {
                App._bicycles.Remove(deleteItem);
            }
        }

        private void Btn_Male_Click(object sender, RoutedEventArgs e)
        {
            Tbx_FilterId.Clear();

            buttonType = "M";
            var lst = from b in App._bicycles where b.status == "Available" && b.category == "M" select b;
            Lbx_Bicycles.ItemsSource = lst;
            
        }

        private void Btn_Female_Click(object sender, RoutedEventArgs e)
        {
            Tbx_FilterId.Clear();

            buttonType = "F";
            var lst = from b in App._bicycles where b.status == "Available" && b.category == "F" select b;
            Lbx_Bicycles.ItemsSource = lst;

        }

        private void Btn_Child_Click(object sender, RoutedEventArgs e)
        {
            Tbx_FilterId.Clear();

            buttonType = "CH";
            var lst = from b in App._bicycles where b.status == "Available" && b.category == "CH" select b;
            Lbx_Bicycles.ItemsSource = lst;

        }

        private void Btn_All_Click(object sender, RoutedEventArgs e)
        {
            Tbx_FilterId.Clear();

            buttonType = "All";

            var lst = from b in App._bicycles select b;
            Lbx_Bicycles.ItemsSource = lst;

        }        


        private void Tbx_filterCustomer_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var lst = from s in App._customers where s.name.ToLower().Contains(filter) select s;
            Lbx_Customers.ItemsSource = lst;
        }

        private void Btn_AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var win_customerDetail = new W_CustomerDetails();
            win_customerDetail.Owner = this;
            Visibility = Visibility.Hidden;
            win_customerDetail.ShowDialog();

            
        }

        

        private void Btn_Hire_Click(object sender, RoutedEventArgs e)
        {
            //string custId = (from c in App._customers where c.firstName == Tbx_firstName.Text && c.lastName == Tbx_lastName.Text select c.customerId).ToString();         

            Booking booking = new Booking() { bookingId = Math.Abs(Guid.NewGuid().GetHashCode()).ToString(), bicycleId = Tbx_BicycleId.Text, customerId = Tbx_CustomerId.Text, status = "Hired", hiringDate = DtPicker_HiringDate.SelectedDate.Value, startTime = Tbx_StartTime.SelectedText.ToString() };

            App._bookings.Add(booking);

            var bookedBicycle = from b in App._bicycles where b.bicycleId == Tbx_BicycleId.Text select b.status;
            
            //App._bicycles.Clear(bookedBicycle);   // how to update status from Available to Hired
            //App._bicycles.Add(bookedBicycle = "Hired");
        }

        private void CoBx_Languages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (firstTime)
            {
                firstTime = false;
                return;
            }
            language = CoBx_Languages.SelectedItem.ToString().Substring(0, 2);            

            Properties.Settings.Default.language = language;
            Properties.Settings.Default.Save();

            Process.Start(Application.ResourceAssembly.Location);
            App.Current.Shutdown();
        }
    }  
   
            
}


