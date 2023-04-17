
namespace design.patterns.Observer.Interfaces
{
    /// <summary>
    /// ISubject - Publish
    /// </summary>
    public interface ISubject
    {
        void Anexar(IObserver observable);
        void Notificar();
    }
}
