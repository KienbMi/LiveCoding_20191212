using NumberGenerator.Logic;

namespace NumberGenerator.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MyNumberGenerator generator = new MyNumberGenerator(100);
            generator.Attach(new TextView());
            generator.Attach(new CounterView());
            generator.Attach(new BarView());
            generator.Attach(new SumView());

            generator.Start();
        }
    }
}
