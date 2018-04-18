using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    public class AppointmentList : IEnumerable
    {
        List<Appointment> appointmentList = null;
        public AppointmentList()
        {
            appointmentList = new List<Appointment>();
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

        public IEnumerator<AppointmentList> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return appointmentList.Count; } 
        }




    }

    public class AppointmentEnum : IEnumerator
    {
        public AppointmentList[] _appList;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public PeopleEnum(Person[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
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

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}
