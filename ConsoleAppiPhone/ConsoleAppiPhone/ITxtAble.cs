using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public interface ITxtAble : ICellService, IDialable
    {
        string SendMessage(ITxtAble otherPhone, string message);
    }
}