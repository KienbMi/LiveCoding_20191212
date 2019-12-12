using NumberGenerator.Logic;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class SumView 
    {
        private int _sum = 0;

        public void NewValueArrived(object sender, MySuperFancyArgs args)
        {
            _sum += args.NewValue;
            Console.WriteLine($"{nameof(SumView)}: Sum => {_sum}");
        }
    }
}