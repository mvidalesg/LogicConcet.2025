﻿using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("ingrese 3 numeros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer numero : ");
    var a = ConsoleExtension.GetInt("Ingrese segundo numero : ");
    var a = ConsoleExtension.GetInt("Ingrese tercer numero : ");

    if (a > b && a > c)
    {
        Console.WriteLine($"El numero mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero mayor es: {b}");
    }
    else
    {
        Console.WriteLine($"El numero mayor es: {c}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("game over");
