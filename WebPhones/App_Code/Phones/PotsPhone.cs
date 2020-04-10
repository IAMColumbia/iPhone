using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class PotsPhone : TelePhone
    {
        protected bool hasDialTone;
        public bool HasDialTone { get { return this.hasDialTone; } }

        public override bool Dial(PhoneNumber NumToDial)
        {
            if (this.hasDialTone)
            {
                return true;
            }
            return false;
        }
    }
}
