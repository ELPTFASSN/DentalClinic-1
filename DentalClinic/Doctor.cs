using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    public class Doctor : User
    {
        string firstName;
        string lastName;
        string emailAddress;
        ulong phoneNumber;

        public Doctor()
        {
            this.firstName = null;
            this.lastName = null;
            this.emailAddress = null;
            this.phoneNumber = 0;
        }

        public Doctor(string firstName, string lastName, string emailAddress, ulong phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public ulong PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public override string ToString()
        {
            return "Dr. " + this.FirstName + " " + this.LastName;
        }
    }
}
