using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public class Phone : IDialable
    {
        public string PhoneNumber { get; set; }

        public Phone()
        {
            this.PhoneNumber = "5882300";
        }

        public virtual string Dial(IDialable otherPhone)
        {
            return $"{this.PhoneNumber} dials {otherPhone.PhoneNumber}";
        }
    }
}
