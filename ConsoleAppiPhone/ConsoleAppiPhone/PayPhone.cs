using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public class PayPhone : POTSPhone, IPayable
    {
        public int Balance { get; protected set; }

        public void AddBalance(int amountToAdd)
        {
            this.Balance += amountToAdd;
        }

        public override string Dial(IDialable otherPhone)
        {
            //Need to have a posisitve babalce to dial
            if (this.Balance > 0)
            {
                this.Balance -= 1;
                return base.Dial(otherPhone) + $" remainf balance is { this.Balance.ToString()}";
            }
            else
                return $"Please add balance.";
        }
    }
}