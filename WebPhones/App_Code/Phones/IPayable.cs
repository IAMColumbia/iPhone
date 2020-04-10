using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public interface IPrePayable
    {
        int MinutesRemaining
        {
            get;
            
        }

        void AddMinutes(int mins);
    }
}
