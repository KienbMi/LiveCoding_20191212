using NumberGenerator.Logic;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class BarView 
    {
        public BarView()
        {
        }

        public void Update(object sender, MySuperFancyArgs args)
        {
            Console.WriteLine($"{nameof(BarView)}: {new string('#', args.NewValue)}");
        }
    }
}