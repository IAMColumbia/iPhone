using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public class PrePaidCellPhone : CellPhone, IPayable
    {
        public int Balance { get; protected set; }

        public void AddBalance(int amountToAdd)
        {
            this.Balance += amountToAdd;   
        }

        public override string Dial(IDialable otherPhone)
        {
            if (this.Balance > 0)
                return base.Dial(otherPhone);
            else
                return "Please add balance";
        }
    }
}