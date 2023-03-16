namespace ConsoleApp2.Models;

public class Dollar
{
    public double Usd { get; set; }

    public Dollar(double usd)
    {
        Usd = usd;
    }

    public static implicit operator Manat(Dollar dollar)
    {
        return new Manat(dollar.Usd * 1.7);
    }
}
