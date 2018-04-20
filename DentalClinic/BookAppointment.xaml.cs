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
    enum DoctorName
    {
        Doctor1 = 1,
        Doctor2 = 2,
        Doctor3 = 3,
        Doctor4 = 4
    }
    enum BloodPressure
    {
        High = 1,
        Low = 2
    }
    enum CompanyName
    {
        Company1 = 1,
        Company2 = 2,
        Company3 = 3,
        Company4 = 4
    }
    /// <summary>
    /// Interaction logic for BookAppointment.xaml
    /// </summary>
    public partial class BookAppointment : Page
    {
        public BookAppointment()
        {
            InitializeComponent();
        }

        private void btnSaveApt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HomeScreen());
        }

        private void cmbDoctor_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get the ComboBox reference.
            var cmbDoctorName = sender as ComboBox;
            var doctorName = Enum.GetNames(typeof(DoctorName));
            cmbDoctorName.ItemsSource = doctorName;
            cmbDoctorName.SelectedIndex = 0;
        }

        private void cmbBloodPressure_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get the ComboBox reference.
            var cmbBloodPressure = sender as ComboBox;
            var bloodPressure = Enum.GetNames(typeof(BloodPressure));
            cmbBloodPressure.ItemsSource = bloodPressure;
            cmbBloodPressure.SelectedIndex = 0;
        }

        private void cmbCompany_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get the ComboBox reference.
            var cmbCompanyName = sender as ComboBox;
            var companyName = Enum.GetNames(typeof(HealthCardCompany));
            cmbCompanyName.ItemsSource = companyName;
            cmbCompanyName.SelectedIndex = 0;
        }

    }
}
