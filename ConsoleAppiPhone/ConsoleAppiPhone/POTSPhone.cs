using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public class POTSPhone : Phone, IPOTSPhone
    {
        public bool hasDialtone { get; set; }

        public POTSPhone()
        {
            this.hasDialtone = false;
        }

        public void PlugPhoneIn()
        {
            this.hasDialtone = true;
        }

        public override string Dial(IDialable otherPhone)
        {
            //Before it's able to dial need dialtone
            if (this.hasDialtone)
                return base.Dial(otherPhone);
            else
                return $"Sorry can't dial not don't have dial tone....";
        }
    }
}