using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public class CellPhone : Phone, ICellService, ITxtAble
    {
        public bool HasService { get; protected set; }

        public int Reception { get; protected set; }

        public CellPhone() : this(false, 0)
        {

        }

        public CellPhone(bool hasService, int reception)
        {
            this.HasService = hasService;
            this.Reception = reception;
        }

        public void AddService()
        {
            this.HasService = true;
        }

        public void MoveToBetterReception()
        {
            this.Reception++;
        }

        public override string Dial(IDialable otherPhone)
        {
            if ((HasService) && (Reception > 0))
            {
                return base.Dial(otherPhone);
            }
            else
            {
                return $"You have noe service or recpetion"; //TODO tell use which is really wrong
            }
        }

        public string SendMessage(ITxtAble otherPhone, string message)
        {
            return $"{this.PhoneNumber} sends {message} to {otherPhone.PhoneNumber}"; 
        }
    }
}