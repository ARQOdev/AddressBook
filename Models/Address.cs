using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    internal class Address : ModelBase
    {
        public Address() : base()
        {
            CityUID = 0;
            AddressName = "";
        }

        public ulong CityUID { get; set; }
        public string AddressName { get; set; }
        public string CityName { get; set; }
        public string FullAddress
        {
            get
            {
                if (string.IsNullOrEmpty(CityName))
                    return AddressName;
                return string.Format("{0}, {1}", CityName, AddressName);
            }
        }
    }
}
