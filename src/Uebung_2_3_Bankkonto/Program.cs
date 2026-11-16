// ------------------------------
// Uebung_2_3_Bankkonto
// ------------------------------

namespace Uebung_2_3_Bankkonto;

class Bankkonto
{
    private double kontostand;
    private double zinssatz;
    private string kontoinhaber;

    public override string ToString()
    {
        return ($"Inhaber: {kontoinhaber}, Kontostand: {kontostand}€, Zinssatz: {zinssatz}%");
    }

    public Bankkonto(double kontostand, double zinssatz, string kontoinhaber)
    {
        this.kontostand = kontostand;
        this.zinssatz = zinssatz;
        this.kontoinhaber = kontoinhaber;
    }

    public void Einzahlungen(double betrag)
    {
        kontostand += betrag; 
    }

    public void Ausbuchung(double betrag)
    {
        kontostand -= betrag;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
