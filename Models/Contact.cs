using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact : ModelBase
    {
        public Contact()
        {
            FirstName = "";
            LastName = "";
            Address = "";
            City = "";
            PhoneNumber = "";
            Email = "";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
