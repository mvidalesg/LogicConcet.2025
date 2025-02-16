using Shared;


do
{
    Console.WriteLine("Ingrese 3 numeros diferentes...");
    var a = ConsoleExtension.GetInt("Ingrese primer numero : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo numero : ");
    if (a == b)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar...");
        continue;
    }
    var c = ConsoleExtension.GetInt("Ingrese tercer numero : ");
    if (b == c > || a == c)
    {
        Console.WriteLine("Deben ser diferentes, vuelva a empezar...");
        continue;
    }
    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($" el mayor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($" el mayor es {a}, el medio es {c}, el menor es {b}");

        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            if (b > c)
            {
                Console.WriteLine($" el mayor es {b}, el medio es {a}, el menor es {c}");
            }
            else
            {
                Console.WriteLine($" el mayor es {b}, el medio es {c}, el menor es {a}");

            }

    }
    else 
    {
            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine($" el mayor es {c}, el medio es {a}, el menor es {b}");
                }
                else
                {
                    Console.WriteLine($" el mayor es {c}, el medio es {b}, el menor es {a}");

                }
            }


    } while (true);



