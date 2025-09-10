using System;

class Prog5
{
    static void Main()
    {
        int x, y;

        while (true)
        {
            Console.WriteLine("Digite a coordenada X:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a coordenada Y:");
            y = int.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
                break;

            if (x > 0 && y > 0)
                Console.WriteLine(x + " " + y + ": primeiro quadrante");
            else if (x < 0 && y > 0)
                Console.WriteLine(x + " " + y + ": segundo quadrante");
            else if (x < 0 && y < 0)
                Console.WriteLine(x + " " + y + ": terceiro quadrante");
            else if (x > 0 && y < 0)
                Console.WriteLine(x + " " + y + ": quarto quadrante");
        }
    }
}
