using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class TelePhone : IDialable
    {
        public PhoneNumber number;
        
        

        public TelePhone()
        {
            this.number = new PhoneNumber(111, 111, 11111);
        }






        #region IDialable Members

        public PhoneNumber PhoneNumber
        {
            get { return this.number; }
        }

        public virtual bool Dial(PhoneNumber phoneToDial)
        {
            return true; 
        }

        #endregion
    }
}
