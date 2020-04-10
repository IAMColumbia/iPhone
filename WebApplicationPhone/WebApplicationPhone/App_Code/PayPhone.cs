using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class PayPhone : PotsPhone, IPrePayable
    {
        protected int minutesRemaining;
        

        public override bool Dial(PhoneNumber NumToDial)
        {
            //Check PotsPhone fist then check minutes remaining
            if (base.Dial(NumToDial) && this.minutesRemaining > 0)
            {
                return true;
            }
            return false;
        }

        #region IPrePayable Members

        public int MinutesRemaining
        {
            get { return this.minutesRemaining; }
        }

        public void AddMinutes(int mins)
        {
            this.minutesRemaining += mins;
        }

        #endregion
    }
}
