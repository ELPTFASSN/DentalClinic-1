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
        public MainWindow()
        {
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

        private AppointmentList ReadXML()
        {
            AppointmentList appList = null;
            //XML Deserialization,reading the xml file saved on disk and putting it in c# object which is later set to datagrid
            try
            {


                using (var reader = XmlReader.Create(@"Appointments.xml"))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(AppointmentList));
                    appList = (AppointmentList)deserializer.Deserialize(reader);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error in reading file");
            }

            return appList;

        }

        private void buttonDisplay_Click(object sender, RoutedEventArgs e)
        {
            AppointmentList li = ReadXML();
            foreach(Appointment ap in li)
            {
                
            }
        }
    }
}
