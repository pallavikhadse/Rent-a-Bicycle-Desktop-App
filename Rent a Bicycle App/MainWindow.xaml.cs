using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace Rent_a_Bicycle_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DigitalClock clock = new DigitalClock();
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
    


        private void Btn_Rent_Click(object sender, RoutedEventArgs e)
        {
            var win_rent = new W_rent();
            win_rent.Owner = this;
            Visibility = Visibility.Hidden;
            win_rent.ShowDialog();            
        }

        private void Btn_Customer_Click(object sender, RoutedEventArgs e)
        {
            var win_customer = new W_CustomerDetails();
            win_customer.Owner = this;
            Visibility = Visibility.Hidden;
            win_customer.ShowDialog();

        }

        private void Btn_Return_Click(object sender, RoutedEventArgs e)
        {
            var win_return = new W_return();
            win_return.Owner = this;
            Visibility = Visibility.Hidden;
            win_return.ShowDialog();

        }

    }
}
