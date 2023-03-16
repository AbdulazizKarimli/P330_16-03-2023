namespace ConsoleApp2.Models;

public class Person
{
    public string Name { get; set; }
    public byte Age { get; set; }

    public Person(string name, byte age)
    {
        Name = name;
        Age = age;
    }

    public virtual string ShowInfo()
    {
        return $"{Name} {Age}";
    }

    public static int operator +(Person person1, Person person2)
    {
        return person1.Age + person2.Age;
    }

    public static bool operator >(Person person1, Person person2)
    {
        return person1.Age > person2.Age;
    }

    public static bool operator <(Person person1, Person person2)
    {
        return person1.Age < person2.Age;
    }
}
