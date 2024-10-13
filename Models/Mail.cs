using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class Mail : ModelBase
    {
        public Mail() : base()
        {
            Email = "";
            PersonUID = 0;
        }
        public string Email { get; set; }
        public ulong PersonUID { get; set; }
    }
}
