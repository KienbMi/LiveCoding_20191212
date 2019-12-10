using NumberGenerator.Logic.Contracts;

namespace NumberGenerator.Logic.Contracts
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
    }
}