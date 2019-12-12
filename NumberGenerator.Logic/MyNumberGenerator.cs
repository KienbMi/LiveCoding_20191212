using System;
using System.Threading.Tasks;

namespace NumberGenerator.Logic
{
    public class MyNumberGenerator
    {
        private const int RANDOM_MIN_VALUE = 1;
        private const int RANDOM_MAX_VALUE = 10;
        private const int MSECONDS_TO_SLEEP = 750;

        private readonly int _nrOfGenerations;

        //public delegate void NumberChangedHandler(int newNumber);

        public MyNumberGenerator(int nrOfGenerations)
        {
            _nrOfGenerations = nrOfGenerations;
        }

        public void Start()
        {
            Random random = new Random();
            for (int i = 0; i < _nrOfGenerations; i++)
            {
                int newNumber = random.Next(RANDOM_MIN_VALUE, RANDOM_MAX_VALUE + 1);
                OnNewNumber(newNumber);
                Task.Delay(MSECONDS_TO_SLEEP).Wait();
                Console.WriteLine("-----------------------------");
            }
        }

        private void OnNewNumber(int newNumber)
        {
            NumberChanged?.Invoke(this, new MySuperFancyArgs(newNumber, -1, "Joe"));
        }

        //public event NumberChangedHandler NumberChanged;
        public event EventHandler<MySuperFancyArgs> NumberChanged;
    }

    public class MySuperFancyArgs : EventArgs
    {
        private readonly int _newValue;
        private readonly int _oldValue;
        private readonly string _name;

        public MySuperFancyArgs(int newValue, int oldValue, string name)
        {
            _newValue = newValue;
            _oldValue = oldValue;
            _name = name;
        }

        public int NewValue
        {
            get { return _newValue; }
        }

        public int OldValue
        {
            get { return _oldValue; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
