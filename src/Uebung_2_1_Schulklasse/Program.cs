// ------------------------------
// Uebung_2_1_Schulklasse
// ------------------------------

using System.Security.Cryptography.X509Certificates;

namespace Uebung_2_1_Schulklasse;

class Schulklasse
{
    private int anzahlSchueler;
    private string klassenVorstand;

    public Schulklasse() :this(22, "Strasser")
    {

    }  

    public Schulklasse(int anzahlSchueler,string klassenVorstand)
    {
        this.anzahlSchueler = anzahlSchueler;
        this.klassenVorstand = klassenVorstand;
    }

    public override string ToString()
    {
        return ($"Anzahl Schüler: {anzahlSchueler}, Klassenvorstand: {klassenVorstand}");
    }

    public void dazu()
    {
        this.anzahlSchueler++;
    }

    public int raus(int delete)
    {
        return anzahlSchueler -= delete;
    }

    public void KlassenwechselNach(Schulklasse klasse)
    {
        this.anzahlSchueler--;
        klasse.anzahlSchueler++;
    }  
}

class Program
{
    static void Main(string[] args)
    {
        Schulklasse klasse1 = new Schulklasse();
        Schulklasse klasse2 = new Schulklasse(20, "Matejka");
        
        Console.WriteLine("Anfang: ");
        Console.WriteLine(klasse1);
        Console.WriteLine($"{klasse2}\n");

        Console.WriteLine("4 Schüler bei Strasser geben auf:");
        klasse1.raus(4);
        Console.WriteLine(klasse1);
        Console.WriteLine(klasse2);

        klasse1.KlassenwechselNach(klasse2);
        Console.WriteLine("\nKlassenwechsel Klasse 1 -> Klasse 2");
        Console.WriteLine(klasse1);
        Console.WriteLine(klasse2);
    }
}
