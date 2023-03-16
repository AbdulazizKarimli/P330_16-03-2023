using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models;

public struct Calculator : ITest
{
    public int A { get; set; }
    public int B { get; set; }

    public int c;

    public Calculator(int a, int b)
    {
        A = a;
        B = b;
        c = 0;
    }

    public Calculator(int a, int b, int c)
    {
        A = a;
        B = b;
        this.c = c;
    }

    public int Sum()
    {
        return A + B;
    }
}