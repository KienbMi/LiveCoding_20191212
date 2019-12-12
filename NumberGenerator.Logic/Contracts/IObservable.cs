using NumberGenerator.Logic.Contracts;

namespace NumberGenerator.Logic.Contracts
{
    public interface IObservable
    {
        delegate void NumberChangedHandler(int newNumber);

        NumberChangedHandler NumberChanged { get; set; }

        //void Attach(IObserver observer);
        //void Detach(IObserver observer);
    }
}