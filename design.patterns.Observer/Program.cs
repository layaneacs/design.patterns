namespace design.patterns.Observer;
internal class Program
{
    private static void Main(string[] args)
    {
        //Os objetos IObserver 'pedem' que o ISubject Notifique quando algo mudar
        var publicador = new Publicador();

        var assinanteA = new AssinanteA();
        publicador.Anexar(assinanteA);
        var assinanteB = new AssinanteB();
        publicador.Anexar(assinanteB);

        Console.WriteLine("Alterando para C:");
        publicador.Nome = "C";

        Console.WriteLine("\nAlterando para B:");
        publicador.Nome = "B";

        Console.WriteLine("\nAlterando para All:");
        publicador.Nome = "All";

        Console.WriteLine("\nAlterando para A:");
        publicador.Nome = "A";

        Console.ReadLine();
    }
}