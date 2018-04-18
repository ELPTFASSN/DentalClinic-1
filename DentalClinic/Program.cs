using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Paitent paitent = new Paitent();
            Appointment appointment = new Appointment();
            Console.WriteLine("Please Ener Name of Patient");
            paitent.FirstName = Console.ReadLine();
            Console.WriteLine("Plese Enter Last Name");
            paitent.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter Email Address");
            paitent.EmailAddress = Console.ReadLine();
            Console.WriteLine("Please Enter Phone Number");
            paitent.PhoneNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Occupation");
            paitent.Occupation = Console.ReadLine();
            Console.WriteLine("Please Enter Appointment Time");
            appointment.Time = Console.ReadLine();
            Console.WriteLine("Please Enter Date");
            appointment.Date = Console.ReadLine();
            Console.WriteLine("Please Write MAin Problem");
            appointment.Problem = Console.ReadLine();

            Console.ReadKey();
        }
    }
}
