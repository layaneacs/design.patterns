using design.patterns.Observer.Interfaces;

namespace design.patterns.Observer
{
    public class Publicador : ISubject
    {
        private string nome = "";
        public string Nome { 
            get { return nome; } 
            set { 
                    nome = value;
                    Notificar(); 
            }
        }

        private List<IObserver> _observers = new List<IObserver>();
        public void Anexar(IObserver observable)
        {
            _observers.Add(observable);
        }

        public void Notificar()
        {
            Console.WriteLine("Publicador: Notificando observers...");

            foreach (var observable in _observers)
            {
                observable.Atualizar(this);
            }
        }
    }
}
