using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese año: ");

    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear) // Corregido: else if en lugar de else (year > currentYear)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }

    // Calculo de año bisiesto simplificado y más legible
    bool esBisiesto = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    Console.WriteLine($"El año: {year}, {(esBisiesto ? "Si" : "No")} {message} bisiesto."); // Uso de operador ternario

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o? ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");