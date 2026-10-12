// ------------------------------
// Uebung_2_1_Schulklasse
// ------------------------------

using System.Security.Cryptography.X509Certificates;

namespace Uebung_2_1_Schulklasse;

public class Schulklasse
{
    private int anzahlSchueler;
    private string klassenVorstand;  

    public Schulklasse(int anzahlSchueler,string klassenVorstand)
    {
        this.anzahlSchueler = anzahlSchueler;
        this.klassenVorstand = klassenVorstand;
    }

    public override string ToString()
    {
        return "Anzahl Schüler: " + anzahlSchueler + ", Klassenvorstand: " + klassenVorstand;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse klasse1 = new Schulklasse(22, "Strasser");
        Schulklasse klasse2 = new Schulklasse(28, "Matejka");

        Console.WriteLine(klasse1);
        Console.WriteLine(klasse2);
    }
}
