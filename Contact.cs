using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contact
    {
        Contact()
        {
            UID = 0;
            FirstName = "";
            LastName = "";
            Address = "";
            City = "";
            PhoneNumber = "";
            Email = "";
        }

        public ulong UID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
