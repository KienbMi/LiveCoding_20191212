using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class SumView : IObserver
    {
        private int _sum = 0;

        public void Update(int newNumber)
        {
            _sum += newNumber;
            Console.WriteLine($"{nameof(SumView)}: Sum => {_sum}");
        }
    }
}