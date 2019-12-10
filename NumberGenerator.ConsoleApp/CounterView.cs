using NumberGenerator.Logic.Contracts;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class CounterView : IObserver
    {
        private int _counter = 0;

        public CounterView()
        {
        }

        public void Update(int newNumber)
        {
            _counter++;
            Console.WriteLine($"{nameof(CounterView)}: Count of numbers => {_counter}");

        }
    }
}