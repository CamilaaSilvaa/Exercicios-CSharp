using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua categoria de habilitação atual (A, B, C): ");
        string categoria = Console.ReadLine().ToUpper();

        Console.Write("Digite o tempo de habilitação em anos: ");
        int tempo = int.Parse(Console.ReadLine());

        if (idade >= 21 && (categoria == "C" || categoria == "E") && tempo >= 2)
        {
            Console.WriteLine("Você pode tirar a habilitação de categoria D.");
        }
        else
        {
            Console.WriteLine("Você NÃO atende aos requisitos.");
        }
    }
}
