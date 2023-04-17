using design.patterns.Observer.Interfaces;

namespace design.patterns.Observer
{
    public class AssinanteA : IObserver
    {
        public void Atualizar(ISubject subject)
        {
            if (subject is Publicador publicador)
            {
                if (publicador.Nome.Equals("A"))
                {
                    Console.WriteLine("AssinanteA: AssinanteA Notificado.");
                }
                if (publicador.Nome.Equals("All"))
                {
                    Console.WriteLine("AssinanteA: Notificado geral");
                }
            }
        }
    }
}
