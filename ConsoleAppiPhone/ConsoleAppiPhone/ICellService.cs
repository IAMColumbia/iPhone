using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppiPhone
{
    public interface ICellService
    {
        bool HasService { get; }
        int Reception { get; }


    }
}