using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    interface User
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        ulong PhoneNumber { get; set; }
    }
}
