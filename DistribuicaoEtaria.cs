using System;
class prog4
{
    static void Main()
    {
        int n, inicio = 0, idade = 0;
        int contador = 0;
        int i = 0, j = 0, k = 0, l = 0, m = 0;

        Console.WriteLine("Digite um numero");
        n = int.Parse(Console.ReadLine());

        while (n > inicio)
        {
            Console.WriteLine("Digite a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 1 && idade <= 15)
            {
                i++;
            }

            if (idade >= 16 && idade <= 30)
            {
                j++;
            }

            if (idade >= 31 && idade <= 45)
            {
                k++;
            }

            if (idade >= 46 && idade <= 60)
            {
                l++;
            }

            if (idade >= 61)
            {
                m++;
            }

            inicio++;

        }
        Console.WriteLine("A quantidade de pessoas entre 1 e 15 anos de idade é de: " + i + " e a porcentagem é de " + (i * 100.0) / n);
        Console.WriteLine("A quantidade de pessoas entre 16 e 30 anos de idade é de: " + j + " e a porcentagem é de " + (j * 100.0) / n);
        Console.WriteLine("A quantidade de pessoas entre 31 e 45 anos de idade é de: " + k + " e a porcentagem é de " + (k * 100.0) / n);
        Console.WriteLine("A quantidade de pessoas entre 46 e 60 anos de idade é de: " + l + " e a porcentagem é de " + (l * 100.0) / n);
        Console.WriteLine("A quantidade de pessoas com mais de 60 anos de idade é de: " + m + " e a porcentagem é de " + (m * 100.0) / n);

    } 
}
