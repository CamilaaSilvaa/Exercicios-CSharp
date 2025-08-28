using System;
class prog7
{
    static void Main(){
        double despesas_restaurante, percentual_gorjeta, valorgorjeta, valor_total;
        
        Console.WriteLine("Digite as despesas do restaurante");
        despesas_restaurante = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o percentual da gorjeta");
        percentual_gorjeta = double.Parse(Console.ReadLine());
        
        valorgorjeta = (despesas_restaurante * percentual_gorjeta)/100;
        valor_total = despesas_restaurante + valorgorjeta; 
        
        Console.WriteLine("O valor da gorjeta: " + valorgorjeta);
        Console.WriteLine("O valor total: " + valor_total);
   }
}
