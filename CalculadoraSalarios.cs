using System;

class prog6
{
    static void Main()
    {
        int opcao = 0;
     
        while (opcao != 4) 
        {
           
            Console.WriteLine("Menu - escolha uma opção");
            Console.WriteLine("1. Novo salário");
            Console.WriteLine("2. Férias");
            Console.WriteLine("3. Décimo terceiro");
            Console.WriteLine("4. Digite para sair");

            Console.Write("Digite a opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 4)
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }

            double salario = -1;

            while (salario < 0) { 
                Console.Write("Digite o salário do funcionário: ");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0)
                    Console.WriteLine("Salário inválido!");
            } 

            switch (opcao)
            {
                case 1: 
                    double aumento = 0;
                    if (salario <= 999.99)
                        aumento = salario * 0.15;
                    else if (salario >= 1000 && salario <= 2000)
                        aumento = salario * 0.10;
                    else
                        aumento = salario * 0.05;

                    Console.WriteLine($"Novo salário: R$ {salario + aumento:F2}");
                    break;

                case 2: 
                    double ferias = salario + (salario / 3);
                    Console.WriteLine($"Valor das férias: R$ {ferias:F2}");
                    break;

                case 3: 
                    int meses = 0;
                    
                    while (meses < 1 || meses > 12)
                    {
                        Console.Write("Digite o número de meses trabalhados (1 a 12): ");
                        meses = int.Parse(Console.ReadLine());
                        if (meses < 1 || meses > 12)
                            Console.WriteLine("Inválido!");
                    } 

                    double decimoTerceiro = salario * meses / 12;
                    Console.WriteLine($"Décimo terceiro: R$ {decimoTerceiro:F2}");
                    break;
            }
        }
    }
}
