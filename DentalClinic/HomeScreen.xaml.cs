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
    /// <summary>
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnBookAppointment_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BookAppointment());
        }

        private void btnFollowUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDisplayApt_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DisplayAppointment());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
        }


    }
}
