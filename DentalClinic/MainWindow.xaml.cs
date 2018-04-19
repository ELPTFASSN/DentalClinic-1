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
using System.Xml.Serialization;

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
            try
            {
                //XML serialization,converting c# object to XML and saving it in a file
                XmlSerializer serializer = new XmlSerializer(typeof(AppointmentList));
                TextWriter writer = new StreamWriter("Appointments.xml");
                serializer.Serialize(writer, li);
                writer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in writing to XML file");
            }
            
        }
    }
}
