using System;
class prog3
{
    static void Main(string[] args)
    {
        double precokwh, quantidadekwh, totalpagar;
        int i, consumidores = 50;
        double maiorConsumoVerificado = 0, menorConsumoVerificado=0, somatotalkwh=0, mediakwh = 0;

        for (i = 0; i < consumidores; i++)
        {
            Console.WriteLine("Digite o preço do kWh:");
            precokwh = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de kWh consumida:");
            quantidadekwh = Convert.ToDouble(Console.ReadLine());

            totalpagar = precokwh * quantidadekwh;
            Console.WriteLine("O valor total a ser pago é: " + totalpagar);

            if (quantidadekwh > maiorConsumoVerificado)
            {
                maiorConsumoVerificado = quantidadekwh;
            }

            else 
            {
                menorConsumoVerificado = quantidadekwh;
            }
            somatotalkwh += quantidadekwh;
        }
        mediakwh = somatotalkwh / consumidores;
        Console.WriteLine("O maior consumo verificado foi: " + maiorConsumoVerificado);
        Console.WriteLine("O menor consumo verificado foi: " + menorConsumoVerificado);
        Console.WriteLine("A média de consumo entre os consumidores foi: " + mediakwh);
            
    }

}
