using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Contact : ModelBase
    {
        public Contact() : base()
        {
            FirstName = "";
            LastName = "";
            Address = "";
            City = "";
            PhoneNumber = "";
            Mail = "";
            Description = "";
            AddressUID = 0;
            CityUID = 0;
            PhoneUID = 0;
            MailUID = 0;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong AddressUID { get; set; }
        public string Address { get; set; }
        public ulong CityUID { get; set; }
        public string City { get; set; }
        public ulong PhoneUID { get; set; }
        public string PhoneNumber { get; set; }
        public ulong MailUID{ get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
    }
}
