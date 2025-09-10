using System;
class prog3
{
    static void Main()
    {
        int dias = 31, x = 0, diaMax = 0;
        double media = 0, total = 0, maior = 0;
        double indice;

        while (x < dias)
        {
            Console.WriteLine("Digite o índice pluviométrico ");
            indice = double.Parse(Console.ReadLine());

            x++;

            total += indice;

            if (indice > maior)
            {
                maior = indice;
                diaMax = x;
            }
        }
            media = total / dias;
            //media sempre fora do loop

            Console.WriteLine(" A media: " + media);
            Console.WriteLine(" O maior índice é " + maior + " e aconteceu no dia " + diaMax);
        
    }
}
