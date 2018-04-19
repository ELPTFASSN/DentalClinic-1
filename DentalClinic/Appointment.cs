using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DentalClinic
{
    public class Appointment:IComparable<Appointment>
    {
        Paitent paitent;
        string time;
        Doctor doctor;
        string date;
        string problem;

        public Appointment(Paitent paitent, string time, Doctor doctor, string date, string problem)
        {
            this.Paitent = paitent;
            this.Time = time;
            this.Doctor = doctor;
            this.Date = date;
            this.Problem = problem;
        }

        public Appointment()
        {
            this.paitent = new Paitent();
            this.time = null;
            this.doctor = new Doctor();
            this.date = null;
            this.problem = null;
        }

        public string Time { get => time; set => time = value; }
        public string Date { get => date; set => date = value; }
        public string Problem { get => problem; set => problem = value; }
        
        public Paitent Paitent { get => paitent; set => paitent = value; }
        public Doctor Doctor { get => doctor; set => doctor = value; }

        public override string ToString()
        {
            return " Appointment: " + paitent.ToString() +" with "+ doctor.ToString() + " at " + time + " - " + date;
        }

        public int CompareTo(Appointment other)
        {
            return this.Time.CompareTo(other.Time);
        }

        public class DataGridAppointment
        {
            string paitent;
            string doctor;
            string time;
            string date;
            string problem; 
        }
    }
}
