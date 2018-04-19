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

namespace DentalClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Program p = new Program();
            AppointmentList li = p.Go();
            foreach(Appointment app in li)
            {
                //Label1.Content = app.ToString();
            }
        }

        private void btnClickDemoPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new DemoPage1();
        }

       
        //private void btnHome(object sender, RoutedEventArgs e)
        //{
        //    MainFrame.Content = new MainWindow();
        //}
    }
}
