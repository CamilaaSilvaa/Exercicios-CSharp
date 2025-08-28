using System;
class prog1
{
    static void Main(){
        double lado, perimetro, area, diagonal;

        Console.WriteLine("Digite o lado");
        lado = double.Parse(Console.ReadLine());
        
        perimetro = 4*lado;
        area = lado * lado;
        diagonal = lado * Math.Sqrt(2);
        
        Console.WriteLine("O perimetro: " + perimetro);
        Console.WriteLine("A area: " + area);
        Console.WriteLine("A diagonal: "+ diagonal);
   }
}
