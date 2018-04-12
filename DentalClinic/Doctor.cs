using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    class Doctor : User
    {
        string firstName;
        string lastName;
        string emailAddress;
        uint phoneNumber;

        public Doctor()
        {
        }

        public Doctor(string firstName, string lastName, string emailAddress, uint phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public uint PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
