using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class TextView : IObserver
    {
        public TextView() 
        {
        }

        public void Update(int newNumber)
        {
            Console.WriteLine($"{nameof(TextView)}: {newNumber}");
        }
    }
}