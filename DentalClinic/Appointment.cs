using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    class Appointment
    {
        Paitent paitent;
        string time;
        Doctor doctor;
        string date;
        string problem;

        public Appointment(Paitent paitent, string time, Doctor doctor, string date, string problem)
        {
            this.paitent = paitent;
            this.time = time;
            this.doctor = doctor;
            this.date = date;
            this.problem = problem;
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
        internal Paitent Paitent { get => paitent; set => paitent = value; }
        internal Doctor Doctor { get => doctor; set => doctor = value; }

        public override string ToString()
        {
            return "Appointments" + paitent +" "+ doctor;
        }
    }
}
