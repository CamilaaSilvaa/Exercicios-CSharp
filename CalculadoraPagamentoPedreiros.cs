using System;
class prog1
{
    static void Main(string[] args)
    {   int i;
        double valorValeAlimentacao = 0, valorValeTransporte = 0, m2pedreiroutilizou = 0;
        double valortotal = 0, valor_metroquadrado;

        for(i=0; i<25; i++)
        {
            Console.WriteLine("Digite os dados do  " + (i+1) + " pedreiro");

            Console.WriteLine("Digite o valor do vale alimentação: ");
            valorValeAlimentacao = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do vale transporte ");
            valorValeTransporte = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos m2 ele produziu");
            m2pedreiroutilizou = double.Parse(Console.ReadLine());

            if(m2pedreiroutilizou < 10)
            {
                valor_metroquadrado = 10;
                valortotal = valorValeAlimentacao + valorValeTransporte + (m2pedreiroutilizou * valor_metroquadrado);
                Console.WriteLine("O valor total a ser pago ao pedreiro é: " + valortotal);
            }

            else if (m2pedreiroutilizou >= 10 && m2pedreiroutilizou <= 20)
            {
                valor_metroquadrado = 11.50;
                valortotal = valorValeAlimentacao + valorValeTransporte + (m2pedreiroutilizou * valor_metroquadrado);
                Console.WriteLine("O valor total a ser pago ao pedreiro é: " + valortotal);
            }

            else
            {
                valor_metroquadrado = 13.00;
                valortotal = valorValeAlimentacao + valorValeTransporte + (m2pedreiroutilizou * valor_metroquadrado);
                Console.WriteLine("O valor total a ser pago ao pedreiro é: " + valortotal);
            }
        }
    }

}
