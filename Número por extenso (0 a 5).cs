using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra: ");
        char letra = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("A letra é uma vogal.");
                break;
            default:
                Console.WriteLine("A letra é uma consoante.");
                break;
        }
    }
}
