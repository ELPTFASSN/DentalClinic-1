using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    enum HealthCardCompany
    {
        OHIP, BLueCross, SunLife, FlexCare
    }
    class InsuranceDetail
    {
        string healthCardNumber;
        string fullName;
        DateTime expiryDate;
        string company;

        public string HealthCardNumber { get => healthCardNumber; set => healthCardNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public string Company { get => company; set => company = value; }
    }
}
