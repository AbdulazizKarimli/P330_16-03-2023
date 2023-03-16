using Core.Entities;
using Utils.Exceptions;

try
{
    User user = new("test@gmail.com", "Pa$$word123!")
    {
        Fullname = "test testov"
    };
    Console.WriteLine(user.ShowInfo());
}
catch (IncorrectPasswordException e)
{
    Console.WriteLine(e.Message);
}