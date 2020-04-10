using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationPhoneNoInterface
{
    public class CellPhone : TelePhone, ITxtAble
    {
        protected CellServices cellService;
        protected CellServices CellService { get { return this.cellService;} }

        protected int signalStrength;
        public int SignalStrength { get { return this.signalStrength; } }

        protected List<PhoneNumber> RecentCalls;

        public CellPhone()
        {
            this.cellService = CellServices.ThreeG;
        }

        public override bool Dial(PhoneNumber NumToDial)
        {
            if (this.signalStrength > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       

        public virtual string SendEmail(string Address, string message)
        {
            //
            return message;
        }

        #region ITxtAble Members

        public string SendText(string textToSend)
        {
            return textToSend;
        }

        #endregion
    }

    public enum CellServices
    {
        Analog, GSM, CDMA, ThreeG, FourG
    }
}
