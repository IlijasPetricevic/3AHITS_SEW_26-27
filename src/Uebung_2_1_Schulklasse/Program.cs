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

    public int dazu()
    {
        return (anzahlSchueler + 1);
    }

    public int raus(int delete)
    {
        return (anzahlSchueler - delete);
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

        Console.WriteLine(klasse1.raus(4));

        
    }
}
