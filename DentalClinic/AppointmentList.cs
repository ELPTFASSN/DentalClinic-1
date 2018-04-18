using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    public class AppointmentList
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
        public int Count
        {
            get { return appointmentList.Count; } 
        }




    }
}
