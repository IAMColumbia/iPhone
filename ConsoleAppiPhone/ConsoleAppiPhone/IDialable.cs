using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public interface IDialable
    {
        string PhoneNumber { get; }

        string Dial(IDialable otherDialable);
    }
}