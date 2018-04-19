using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DentalClinic
{
    [XmlRoot("Paitent")]
    [Serializable]
    public class Paitent : User
    {
        string firstName;
        string lastName;
        string emailAddress;
        uint phoneNumber;
        string occupation;
        MedicalHistory medicalHistory;
        InsuranceDetail insuranceDetail;

        public Paitent()
        {
            this.FirstName = null;
            this.LastName = null;
            this.EmailAddress = null;
            this.PhoneNumber = 0;
            this.Occupation = null;
            medicalHistory = new MedicalHistory();
            insuranceDetail = new InsuranceDetail();
        }

        public Paitent(string firstName, string lastName, string emailAddress, uint phoneNumber, string occupation, MedicalHistory medicalHistory, InsuranceDetail insuranceDetail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
            this.Occupation = occupation;
            this.MedicalHistory = medicalHistory;
            this.InsuranceDetail = insuranceDetail;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public uint PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public MedicalHistory MedicalHistory { get => medicalHistory; set => medicalHistory = value; }
        public InsuranceDetail InsuranceDetail { get => insuranceDetail; set => insuranceDetail = value; }

        public override string ToString()
        {
            return "Patient: "+FirstName +" "+ LastName;
        }
    }
}
