namespace ClassDemo;


public class Program
{
    public string GetFullName(string firstName, string lastName, string? middleName = null)
    {
        //string fullName = firstName + " ";
        //if (middleName != null)
        //{
        //fullName += middleName + " ";
        //}
        //return fullName + lastName;

        //return $"{firstName}{middleName ?? ""}{lastName}";
        return firstName + $"{(middleName != null ? ' ' + middleName : ' ')}" + lastName;

        //return firstName + " " + middleName + " " + lastName;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void Login(string username, string password)
    {
        if (!TryLogin(username, password))
        {
            throw new InvalidOperationException("Your login is not valid");
        }
    }
  
    public bool TryLogin(string username, string password)
    {
        if (password == "goodpassword")
        {
            return true;
        }
        return false;
        // Moq library in C#
    }

    public bool TryConvert(string number, out int? result)
    {
        if (number == "one")
        {
            result = 1;
            return true;
        }
        else
        {
            result = null;
            return false;
        }
    }
}
