// ------------------------------
// Uebung_2_2_Rechteck
// ------------------------------

namespace Uebung_2_2_Rechteck;

class Rechteck
{
    private double a;
    private double b;

    public Rechteck(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public Rechteck() : this(10, 20)
    {
        
    }

    public override string ToString()
    {
        return ($"a: {a} b: {b}");
    }

    public void Resize()
    {
        if (a > b)
        {
            a -= b;
        }
        else
        {
            b -= a;
        }
    }

    public void Inflate(double percent)
    {
        a += a * percent / 100;
        b += b * percent / 100;
    }

    public double AspectRatio()
    {
        return a / b;
    }

    public void SetMaxSide(double newMax)
    {
        double factor;
        
        if (a >= b)
        {
            factor = newMax / a;
            a = newMax;
            b = b * factor;
        }
        else
        {
            factor = newMax / b;
            b = newMax;
            a = a * factor;
        }
    }

    public double Area()
    {
        return a * b;
    }

    public int Tile(Rechteck r)
    {
       return (int) (this.Area() / r.Area());
    }
}   


class Program
{
    static void Main(string[] args)
    {
        int anzahl;

        Rechteck r1 = new Rechteck();
        Rechteck r2 = new Rechteck(5.5, 12);

        Console.WriteLine($"Rechteck 1: {r1}");
        Console.WriteLine($"Rechteck 2: {r2}");
        /*
        r2.Resize();
        Console.WriteLine($"Rechteck 2 nach Resize: {r2}");

        r2.Inflate(50);
        Console.WriteLine($"Rechteck 2 nach Inflate von 50: {r2}");
        */
        Console.WriteLine($"Seitenverhältnis von Rechteck 2: {r2.AspectRatio()}");
        /*
        r2.SetMaxSide(20);
        Console.WriteLine($"Rechteck 2 nach SetMaxSide von 20: {r2}");
        */
        Console.WriteLine($"Fläche von Rechteck 2: {r2.Area()}");
        /*
        anzahl = r1.Tile(r2);
        Console.WriteLine($"Rechteck r2 passt {anzahl}-mal in Rechteck r1");
        */
    }
}
