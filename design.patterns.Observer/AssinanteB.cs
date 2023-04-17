using design.patterns.Observer.Interfaces;

namespace design.patterns.Observer
{
    public class AssinanteB : IObserver
    {
        public void Atualizar(ISubject subject)
        {
            if (subject is Publicador publicador)
            {
                if (publicador.Nome.Equals("B"))
                {
                    Console.WriteLine("AssinanteB: AssinanteB Notificado.");
                }
                if (publicador.Nome.Equals("All"))
                {
                    Console.WriteLine("AssinanteB: Notificado geral");
                }
            }
        }
    }
}
