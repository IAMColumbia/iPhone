using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class VoipPhone : TelePhone
    {
        protected bool hasNetwork;
        public bool HasNetwork { get { return this.hasNetwork; } }

        public override bool Dial(PhoneNumber NumToDial)
        {
            if (this.hasNetwork)
            {
                return true;
            }
            return false;
        }
    }
}
