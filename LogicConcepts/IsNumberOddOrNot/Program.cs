﻿using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("Ingrese numero entero: ");

    if (number % 2 == 0)
    {
        Console.WriteLine($"El numero {number}, es par.");
    }
    else
    {
        Console.WriteLine($"El numero {number}, es impar.");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o? ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");
