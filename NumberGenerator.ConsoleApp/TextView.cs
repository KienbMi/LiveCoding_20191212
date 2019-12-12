using NumberGenerator.Logic;
using System;

namespace NumberGenerator.ConsoleApp
{
    internal class TextView 
    {
        public TextView() 
        {
        }

        public void Update(object sender, MySuperFancyArgs args)
        {
            Console.WriteLine($"{nameof(TextView)}: {args.NewValue}");
        }
    }
}