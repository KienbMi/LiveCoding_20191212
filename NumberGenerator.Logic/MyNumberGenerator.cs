using NumberGenerator.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NumberGenerator.Logic
{
    public class MyNumberGenerator : IObservable
    {
        private const int RANDOM_MIN_VALUE = 1;
        private const int RANDOM_MAX_VALUE = 10;
        private const int MSECONDS_TO_SLEEP = 750;

        private readonly int _nrOfGenerations;
        private readonly IList<IObserver> _observers; 

        public MyNumberGenerator(int nrOfGenerations)
        {
            _nrOfGenerations = nrOfGenerations;
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (_observers.Contains(observer))
            {
                throw new InvalidOperationException("Observer is already attached!");
            }

            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (!_observers.Contains(observer))
            {
                throw new InvalidOperationException("Observer was not attached!");
            }

            _observers.Remove(observer);
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
            foreach (IObserver observer in _observers)
            {
                observer.Update(newNumber);
            }
        }
    }
}
