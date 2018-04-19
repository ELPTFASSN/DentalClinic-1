using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DentalClinic
{
    [XmlRoot("AppointmentList")]
    public class AppointmentList : IEnumerable
    {
        [XmlArray("Appointments")]
        [XmlArrayItem("Appointment")]
        public ObservableCollection<Appointment> appointmentList = null;
        public AppointmentList()
        {
            appointmentList = new ObservableCollection<Appointment>();
        }

        public Appointment this[int i]
        {
            get { return appointmentList[i]; }
            set { appointmentList[i] = value; }
        }

        public void Add(Appointment appointment)
        {
            appointmentList.Add(appointment);
        }

        public void Remove(Appointment appointment)
        {
            appointmentList.Remove(appointment);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public AppointmentEnum GetEnumerator()
        {
            return new AppointmentEnum(appointmentList);
        }

        public int Count
        {
            get { return appointmentList.Count; } 
        }

    }

    public class AppointmentEnum : IEnumerator
    {
        public ObservableCollection<Appointment> _appList;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public AppointmentEnum(ObservableCollection<Appointment> list)
        {
            _appList = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _appList.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Appointment Current
        {
            get
            {
                try
                {
                    return _appList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        
    }

}
