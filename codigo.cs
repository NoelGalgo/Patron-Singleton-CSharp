using System;

public class Central_911
{
    private static Central_911 instancia;

    private Central_911()
    {
        Console.WriteLine("Central 911 creada");
    }

    public static Central_911 ObtenerInstancia()
    {
        if (instancia == null)
        {
            instancia = new Central_911();
        }

        return instancia;
    }

    public void RecibirLlamada(string emergencia)
    {
        Console.WriteLine("Atendiendo emergencia: " + emergencia);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Central_911 central1 = Central_911.ObtenerInstancia();
        Central_911 central2 = Central_911.ObtenerInstancia();

        central1.RecibirLlamada("Incendio");
        central2.RecibirLlamada("Accidente");

        Console.WriteLine("¿Es la misma instancia?");
        Console.WriteLine(Object.ReferenceEquals(central1, central2));

        Console.ReadKey();
    }
}
