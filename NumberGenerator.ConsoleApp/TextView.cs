using System;

namespace NumberGenerator.ConsoleApp
{
    internal class TextView 
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