namespace design.patterns.Observer.Interfaces
{
    /// <summary>
    /// IObserver - Subscriber
    /// </summary>
    public interface IObserver
    {
        void Atualizar(ISubject subject);
    }
}
