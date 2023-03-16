namespace ConsoleApp2.Models;

public class Manat
{
    public double Azn { get; set; }

    public Manat(double azn)
    {
        Azn = azn;
    }

    public static explicit operator Dollar(Manat manat)
    {
        return new Dollar(manat.Azn / 1.7);
    }
}
