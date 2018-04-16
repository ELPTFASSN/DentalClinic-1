using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    enum HealthCardCompany
    {
        OHIP, BLueCross, ManuLife, FlexCare
    }
    class InsuranceDetail
    {
        string healthCardNumber;
        string fullName;
        string expiryDate;
        string company;

        public InsuranceDetail(string healthCardNumber, string fullName, string expiryDate, string company)
        {
            this.healthCardNumber = healthCardNumber;
            this.fullName = fullName;
            this.expiryDate = expiryDate;
            this.company = company;
        }

        public InsuranceDetail()
        {
            this.healthCardNumber = null;
            this.fullName = null;
            this.expiryDate = null;
            this.company = null;

        }

        public string HealthCardNumber { get => healthCardNumber; set => healthCardNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string Company { get => company; set => company = value; }

        public override string ToString()
        {
            return "Insurance Details: "+healthCardNumber+" " + company;
        }
    }
}
