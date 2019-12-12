using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class BarView 
    {
        public BarView()
        {
        }

        public void Update(int newNumber)
        {
            Console.WriteLine($"{nameof(BarView)}: {new string('#', newNumber)}");
        }
    }
}