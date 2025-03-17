namespace TP3_12;

public class Program
{
    public static void Main(string[] args)
    {

        Circulo circulo = new Circulo();
        Esfera esfera = new Esfera();

        circulo.Raio = 3.0;
        esfera.Raio = 5.0;

        double areaCirculo = circulo.CalcularArea();
        Console.WriteLine($"Área do Círculo: {areaCirculo}");

        double volumeEsfera = esfera.CalcularVolume();
        Console.WriteLine($"Volume da Esfera: {volumeEsfera}");
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