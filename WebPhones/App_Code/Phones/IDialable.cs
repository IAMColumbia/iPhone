using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public interface IDialable
    {

        PhoneNumber PhoneNumber
        {
            get;
        }

        bool Dial(PhoneNumber phoneToDial);
    }
}
