using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class City : ModelBase
    {
        public City() : base()
        {
            CityName = "";
        }

        public City(string city_name) : base()
        {
            CityName = city_name;
        }

        public string CityName { get; set; }



    }
}
