// Define la clase base abstracta 'Pais'
public abstract class Pais
{
    // Define las propiedades abstractas
    public abstract string ColorBandera { get; }
    public abstract double Tamaño { get; }
    public abstract string IdiomaOficial { get; }
}

// Define la clase 'Ecuador' que hereda de 'Pais'
public class Ecuador : Pais
{
    public override string ColorBandera { get { return "Amarillo, Azul, Rojo"; } }
    public override double Tamaño { get { return 283560; } } //coloco la distancia en kilómetros cuadrados
    public override string IdiomaOficial { get { return "Español"; } }
}

// Define la clase 'Brasil' que hereda de 'Pais'
public class Brasil : Pais
{
    public override string ColorBandera { get { return "Verde, Amarillo, Azul"; } }
    public override double Tamaño { get { return 8515767; } } //coloco la distancia en kilómetros cuadrados
    public override string IdiomaOficial { get { return "Portugués"; } }
}

// Define la clase 'Andorra' que hereda de 'Pais'
public class Andorra : Pais
{
    public override string ColorBandera { get { return "Azul, Amarillo, Rojo"; } }
    public override double Tamaño { get { return 468; } } // en kilómetros cuadrados
    public override string IdiomaOficial { get { return "Catalán"; } }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de los países
        Pais ecuador = new Ecuador();
        Pais brasil = new Brasil();
        Pais andorra = new Andorra();

        // Imprimir la información requerida
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera);
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño + " kilómetros cuadrados");
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial);

        Console.ReadLine();
    }
}