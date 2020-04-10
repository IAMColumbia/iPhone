using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class PrePaidPhone : CellPhone, IPrePayable
    {
        protected int minutesRemaining;
       

        public override bool Dial(PhoneNumber NumToDial)
        {
            if (base.Dial(NumToDial) && this.MinutesRemaining > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        #region IPrePayable Members

        public int MinutesRemaining
        {
            get { return this.minutesRemaining ; }
        }

        public void AddMinutes(int mins)
        {
            this.minutesRemaining += mins;
        }

        #endregion
    }
}
