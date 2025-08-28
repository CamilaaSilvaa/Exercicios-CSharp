using System;
class prog4
{
    static void Main()
    {
        int numero;
        //Como quer saber se o numero é divisivel por 3 e 5, o ideal é fazer modulo e não divisão
        Console.WriteLine("Digite um número inteiro:");
        numero = int.Parse(Console.ReadLine());

        if (numero % 3 == 0 && numero % 5 == 0)
            Console.WriteLine("Ele é divisível por 3 e 5");
        else
            Console.WriteLine("Não é divisível por 3 e 5");
    }
}
