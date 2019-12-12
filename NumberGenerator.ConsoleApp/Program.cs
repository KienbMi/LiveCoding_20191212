using NumberGenerator.Logic;

namespace NumberGenerator.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MyNumberGenerator generator = new MyNumberGenerator(100);
            //generator.Attach(new TextView());
            //generator.Attach(new CounterView());
            //generator.Attach(new BarView());
            //generator.Attach(new SumView());

            TextView textView = new TextView();
            BarView barView = new BarView();
            SumView sumView = new SumView();

            generator.NumberChanged += textView.Update;
            generator.NumberChanged += barView.Update;
            generator.NumberChanged += NewNumberWasGenerated;
            generator.NumberChanged += sumView.NewValueArrived;

            generator.Start();
        }

        static void NewNumberWasGenerated(int newNumber)
        {
            System.Console.WriteLine($"---> NewNumberWasGeneratede: {newNumber}");
        }
    }
}
