using Shared

using System.ComponentModel.Design;

do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("ingrese año: ");

    if (year == currentYear)
    {
        message = "es";
    } else (year > currentYear)
    {
        message = "va a ser";   
    }
    else
    {
        message = "fue";
    }


 if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año : {year}, Si {message} biciestos.");
            }
            else
            {
                Console.WriteLine($"El año : {year}, No {message} biciestos.");
            }
        }
        else
        {
            Console.WriteLine($"El año : {year}, Si {message} biciestos.");
        }
    }
    else
    {
        Console.WriteLine($"El año : {year}, No {message} biciestos.");
    }
} while (true);