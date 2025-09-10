using System;
class prog2
{
    static void Main()
    {
        int x, y;

        Console.WriteLine("Digite dois numeros inteiros impares:");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if ((x % 2 == 0) && (y % 2 == 0) && (x > y))
        {
            Console.WriteLine("Erro! Valores invalidos.");
        }

        while(x <= y)
        {
            Console.WriteLine(x);
            x += 2;
        }
    }
}

