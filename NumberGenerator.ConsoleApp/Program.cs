using NumberGenerator.Logic;

namespace NumberGenerator.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            MyNumberGenerator generator = new MyNumberGenerator(100);

            TextView textView = new TextView();
            BarView barView = new BarView();
            SumView sumView = new SumView();

            generator.NumberChanged += textView.Update;
            generator.NumberChanged += barView.Update;
            generator.NumberChanged += NewNumberWasGenerated;
            generator.NumberChanged += sumView.NewValueArrived;

            generator.Start();
        }

        static void NewNumberWasGenerated(object sender, MySuperFancyArgs args)
        {
            System.Console.WriteLine($"---> NewNumberWasGeneratede: {args.NewValue}");
        }
    }
}
