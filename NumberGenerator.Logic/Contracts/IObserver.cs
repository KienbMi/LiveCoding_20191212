using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGenerator.Logic.Contracts
{
    public interface IObserver
    {
        void Update(int newNumber);
    }
}
