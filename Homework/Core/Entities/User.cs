using Core.Interfaces;
using Utils.Exceptions;

namespace Core.Entities;

public class User : IAccount
{
    private static int _id;
    private string _password;

    public int Id { get; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password 
    {
        get => _password;
        set
        {
            if (PasswordChecker(value))
                _password = value;
            else
                throw new IncorrectPasswordException("Shifre duzgun formatda deyil");
        }
    }

    public User(string email, string password)
    {
        Id = ++_id;
        Email = email;
        Password = password;
    }

    public bool PasswordChecker(string password)
    {
        if(!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (var item in password)
            {
                if (char.IsUpper(item))
                    hasUpper = true;
                else if (char.IsLower(item))
                    hasLower = true;
                else if(char.IsDigit(item))
                    hasDigit = true;

                if (hasUpper && hasLower && hasDigit)
                    return true;
            }
        }

        return false;
    }

    public string ShowInfo()
    {
        return $"{Id} - {Fullname} - {Email}";
    }
}