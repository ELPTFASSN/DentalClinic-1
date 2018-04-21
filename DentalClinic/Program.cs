using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    public class Program
    {
        

        public List<Doctor> docList()
        {
            List<Doctor> li = new List<Doctor>();
            Doctor doctor1 = new Doctor("Stephen", "Smith", "ss@dfds.com", 324455);
            Doctor doctor2 = new Doctor("Jeffrey", "Williams", "jw@dfds.com", 123456);
            Doctor doctor3 = new Doctor("Charles", "Brown", "cb@dfds.com", 789456);
            Doctor doctor4 = new Doctor("Daniel", "Jones", "dj@dfds.com", 456123);
            Doctor doctor5 = new Doctor("Steven", "Davis", "sd@dfds.com", 123789);
            li.Add(doctor1);
            li.Add(doctor2);
            li.Add(doctor3);
            li.Add(doctor4);
            li.Add(doctor5);
            return li;
        }
    }
}
