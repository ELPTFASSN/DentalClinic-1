using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Xml.Serialization;

namespace DentalClinic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static AppointmentList appointmentList;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            AppointmentList = new AppointmentList();
        }

        public static AppointmentList AppointmentList { get => appointmentList;

            set => appointmentList = value; }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.Navigate(new HomeScreen());
        }

    }
}
