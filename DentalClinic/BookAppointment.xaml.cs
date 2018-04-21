﻿using System;
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
            bool result = true;
            if (txtFName.Text.Length == 0)
            {
                result = false;
                txtFName.BorderBrush = Brushes.Red;
                txtFName.BorderThickness = new Thickness(5);
            }
            if (txtLName.Text.Length == 0)
            {
                result = false;
                txtLName.BorderBrush = Brushes.Red;
                txtLName.BorderThickness = new Thickness(5);
            }
            if (txtPhoneNo.Text.Length == 0)
            {
                result = false;
                txtPhoneNo.BorderBrush = Brushes.Red;
                txtPhoneNo.BorderThickness = new Thickness(5);
            }
            if (!CheckPhoneNo(txtPhoneNo.Text))
            {
                result = false;
            }
            if (txtEmail.Text.Length == 0)
            {
                result = false;
                txtEmail.BorderBrush = Brushes.Red;
                txtEmail.BorderThickness = new Thickness(5);
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                result = false;
            }
            if (txtOccupation.Text.Length == 0)
            {
                result = false;
                txtOccupation.BorderBrush = Brushes.Red;
                txtOccupation.BorderThickness = new Thickness(5);
            }
            if (txtProblem.Text.Length == 0)
            {
                result = false;
                txtProblem.BorderBrush = Brushes.Red;
                txtProblem.BorderThickness = new Thickness(5);
            }
            if (txtDate.Text.Length == 0)
            {
                result = false;
                txtDate.BorderBrush = Brushes.Red;
                txtDate.BorderThickness = new Thickness(5);
            }
            //DateTime dDate;
            //dDate = DateTime.Parse(txtDate.Text);
            //String.Format("{0:d/MM/yyyy}", dDate);

            DateTime dt;
            bool valid = DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt);
            if (valid == false)
            {
                result = false;
                txtDate.BorderBrush = Brushes.Red;
                txtDate.BorderThickness = new Thickness(5);
            }

            if (cmbTime.Text.Length == 0)
            {
                result = false;
                cmbTime.BorderBrush = Brushes.Red;
                cmbTime.BorderThickness = new Thickness(5);
            }
            if (cmbDoctor.Text.Length == 0)
            {
                result = false;
                cmbDoctor.BorderBrush = Brushes.Red;
                cmbDoctor.BorderThickness = new Thickness(5);
            }
            if (txtblockAlergy.Text.Length == 0)
            {
                result = false;
                txtblockAlergy.BorderBrush = Brushes.Red;
                txtblockAlergy.BorderThickness = new Thickness(5);
            }
            if (txtHeartDieases.Text.Length == 0)
            {
                result = false;
                txtHeartDieases.BorderBrush = Brushes.Red;
                txtHeartDieases.BorderThickness = new Thickness(5);
            }
            if (cmbBloodPressure.Text.Length == 0)
            {
                result = false;
                cmbBloodPressure.BorderBrush = Brushes.Red;
                cmbBloodPressure.BorderThickness = new Thickness(5);
            }
            if (txtHealthCardNo.Text.Length == 0)
            {
                result = false;
                txtHealthCardNo.BorderBrush = Brushes.Red;
                txtHealthCardNo.BorderThickness = new Thickness(5);
            }
            if (txtHealthCardName.Text.Length == 0)
            {
                result = false;
                txtHealthCardName.BorderBrush = Brushes.Red;
                txtHealthCardName.BorderThickness = new Thickness(5);
            }
            if (txtExpiryDate.Text.Length == 0)
            {
                result = false;
                txtExpiryDate.BorderBrush = Brushes.Red;
                txtExpiryDate.BorderThickness = new Thickness(5);
            }
            DateTime dtExpDate;
            bool validExpDate = DateTime.TryParseExact(txtExpiryDate.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dtExpDate);
            if (validExpDate == false)
            {
                result = false;
                txtExpiryDate.BorderBrush = Brushes.Red;
                txtExpiryDate.BorderThickness = new Thickness(5);
            }
            if (cmbCompany.Text.Length == 0)
            {
                result = false;
                cmbCompany.BorderBrush = Brushes.Red;
                cmbCompany.BorderThickness = new Thickness(5);
            }
            if (result)
            {
            }
        }

        private bool CheckPhoneNo(string phoneNo)
        {
            try
            {
                int result;
                if (phoneNo.Length == 0)
                {
                    return false;
                }
                else
                {
                    return int.TryParse(phoneNo, out result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
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

        private void txtPhoneNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tbPhoneNo = (TextBox)sender;
            tbPhoneNo.Foreground = Brushes.Black;
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tbEmail = (TextBox)sender;
            tbEmail.Foreground = Brushes.Black;
        }

        private void txtFName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtFName.BorderBrush = Brushes.Black;
            txtFName.BorderThickness = new Thickness(1);
        }

        private void txtLName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLName.BorderBrush = Brushes.Black;
            txtLName.BorderThickness = new Thickness(1);
        }

        private void txtOccupation_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtOccupation.BorderBrush = Brushes.Black;
            txtOccupation.BorderThickness = new Thickness(1);
        }

        private void txtProblem_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtProblem.BorderBrush = Brushes.Black;
            txtProblem.BorderThickness = new Thickness(1);
        }

        private void txtDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtDate.BorderBrush = Brushes.Black;
            txtDate.BorderThickness = new Thickness(1);
        }

        private void cmbTime_StylusUp(object sender, StylusEventArgs e)
        {
            //txtDate.BorderBrush = Brushes.Black;
            //txtDate.BorderThickness = new Thickness(1);
        }

        private void txtblockAlergy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtblockAlergy.BorderBrush = Brushes.Black;
            txtblockAlergy.BorderThickness = new Thickness(1);
        }

        private void txtHeartDieases_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHeartDieases.BorderBrush = Brushes.Black;
            txtHeartDieases.BorderThickness = new Thickness(1);
        }

        private void txtHealthCardNo_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHealthCardNo.BorderBrush = Brushes.Black;
            txtHealthCardNo.BorderThickness = new Thickness(1);
        }

        private void txtHealthCardName_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtHealthCardName.BorderBrush = Brushes.Black;
            txtHealthCardName.BorderThickness = new Thickness(1);
        }

        private void txtExpiryDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtExpiryDate.BorderBrush = Brushes.Black;
            txtExpiryDate.BorderThickness = new Thickness(1);
        }
    }
}
