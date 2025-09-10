using System;
class prog2
{
    static void Main(string[] args)
    {
        int n;
        double soma = 1, denominador = 1, numerador = 1;

        //denominador igual a 1 pq um numero multiplicado por 0 é sempre 0

        Console.Write("Digite um numero inteiro positivo: ");
        n = int.Parse(Console.ReadLine());

        //3! = 3 × 2 × 1 = 6
        //5! = 5 × 4 × 3 × 2 × 1 = 120

        for (int i = 1; i <= n; i++)
        {
            denominador *= i;
            soma += numerador / denominador;

        }

        Console.WriteLine("A soma dos termos é de: " + soma);

    }

}
