namespace TP3_11;

public class Program
{
    public static void Main(string[] args)
    {

    }
}

public class Circulo
{
    public double Raio;

    public double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}

public class Esfera
{
    public double Raio;

    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
    }
}