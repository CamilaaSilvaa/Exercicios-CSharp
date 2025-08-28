using System;
class prog6
{
    static void Main(){
        double numerador, denominador, fracao;
        
        Console.WriteLine("Digite o numerador");
        numerador = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o denominador");
        denominador = double.Parse(Console.ReadLine());
        
        fracao = numerador/denominador;
        
        Console.WriteLine($"Valor da fracao: {fracao:f2}");
   }
}
