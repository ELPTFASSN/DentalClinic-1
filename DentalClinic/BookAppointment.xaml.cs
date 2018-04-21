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
        No = 0,
        High = 1,
        Low = 2
    }

    enum Time
    {
        AM9h = 0,
        AM9h30m = 1,
        AM10h = 2,
        AM10h30m = 3,
        AM11h = 4,
        AM11h30m = 5,
        PM1h = 6,
        PM1h30m = 7,
        PM2h = 8,
        PM2h30m = 9,
        PM3h = 10,
        PM3h30m = 11
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
            //// ... Get the ComboBox reference.
            //var cmbDoctorName = sender as ComboBox;
            //var doctorName = Enum.GetNames(typeof(DoctorName));
            //cmbDoctorName.ItemsSource = doctorName;
            //cmbDoctorName.SelectedIndex = 0;

            Program p = new Program();
            List<Doctor> listDoctor = new List<Doctor>();
            listDoctor = p.docList();
            // ... Get the ComboBox reference.
            var comboBoxDoctor = sender as ComboBox;

            //foreach(var item in listDoctor)
            //{
            //    // ... Assign the ItemsSource to the List.
            //    comboBoxDate.ItemsSource = item.FirstName + " "+ item.LastName;

            //}

            // ... Assign the ItemsSource to the List.
            comboBoxDoctor.ItemsSource = listDoctor;

            // ... Make the first item selected.
            comboBoxDoctor.SelectedIndex = 0;

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

        private void cmbTime_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> listTime = new List<string>();
            var timeTypes = Enum.GetNames(typeof(Time));
            var timeValues = Enum.GetValues(typeof(Time));
            //Fill the time slots (rearranging AM10h30m into 10:30am)
            for (int i = 0; i < timeTypes.Length; i++)
            {
                string timeType = (string)timeTypes[i];
                int timePlace = (int)timeValues.GetValue(i);
                string ampm = timeType.Substring(0, 2);
                string usTime = timeType.Substring(2).Replace('m', ' ');
                if (usTime.IndexOf('h') == usTime.Length - 1)
                {
                    usTime = usTime.Replace('h', ':') + "00 ";
                }
                else
                {
                    usTime = usTime.Replace('h', ':');
                }
                usTime += ampm;
                listTime.Add(usTime);
                //Array of appointments initialized
                //appointments[i] = new Appointment();
                //appointments[i].Time = usTime;
            }
            // ... Get the ComboBox reference.
            var comboBoxTime = sender as ComboBox;
            // ... Assign the ItemsSource to the List.
            comboBoxTime.ItemsSource = listTime;
            // ... Make the first item selected.
            comboBoxTime.SelectedIndex = 0;
        }

    }
}
