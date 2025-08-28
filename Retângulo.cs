using System;
class prog2
{
    static void Main(){
        double base1, altura, perimetro, area, diagonal;
        //base é uma palavra reservada

        Console.WriteLine("Digite a base");
        base1= double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a altura");
        altura = double.Parse(Console.ReadLine());
        
        perimetro = 2 * (base1 + altura);
        area = base1 * altura;
        diagonal = Math.Sqrt(base1 * base1 + altura * altura);
        
        Console.WriteLine("O perimetro: " + perimetro);
        Console.WriteLine("A area: " + area);
        Console.WriteLine("A diagonal: "+ diagonal);
   }
}
