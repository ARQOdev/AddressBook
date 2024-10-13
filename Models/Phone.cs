using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Phone : ModelBase
    {
        public Phone() : base()
        {
            Number = "";
            PersonUID = 0;
        }

        public string Number { get; set; }
        public ulong PersonUID { get; set; }
    }
}
