namespace ConsoleApp2.Models;

public class Employee : Person
{
    public int Salary { get; set; }

    public Employee(string name, byte age, int salary) : base(name, age)
    {
        Salary = salary;
    }

    public override string ShowInfo()
    {
        return $"{base.ShowInfo()} {Salary}";
    }
}
