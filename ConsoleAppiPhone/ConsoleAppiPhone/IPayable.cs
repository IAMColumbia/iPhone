using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public interface IPayable
    {
        int Balance { get; }

        void AddBalance(int amountToAdd);
    }
}