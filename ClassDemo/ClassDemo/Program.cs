using System.Text;

namespace ClassDemo;

public class Program
{
    /// <summary>
    /// List of strings, join together by delimiter, ignore null or empty
    /// </summary>
    /// <param name="inputStrings">An array of strings that are...</param>
    /// <returns></returns>
    public static string JoinStringByDelimiter(string?[] inputStrings)
    {
        ArgumentNullException.ThrowIfNull(inputStrings);

        StringBuilder result = new();
        
        if(inputStrings.Length > 0)
        {
            result.Append(inputStrings[0]);

            /* runs for each element. doesnt go out of bounds
            * 1.. means ignore the first element
            * where finds all the elements that satisfy condition... just like where clause in SQL*/

            foreach (string?  inputString in inputStrings[1..].Where(item => !string.IsNullOrEmpty(item))) 
            {
                if (inputString != null) 
                {
                    result.Append(" ");
                    result.Append(inputString);
                }
            }
        
        }
        return result.ToString(); //returns empty string for null
    }


    public string GetFullName(string firstName, string lastName, string? middleName = null)
    {
        return JoinStringByDelimiter([firstName, lastName, middleName]);
        //return firstName + $"{(middleName != null ? ' ' + middleName + ' ' : ' ')}" + lastName;
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
