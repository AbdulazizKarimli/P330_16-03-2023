namespace ConsoleApp2.Models;

public class Developer : Employee
{
    public string Position { get; set; }  

    public Developer(string name, byte age, int salary, string position) : base(name, age, salary)
    {
        Position = position;
    }

    public override string ShowInfo()
    {
        return $"{base.ShowInfo()} {Position}";
    }
}