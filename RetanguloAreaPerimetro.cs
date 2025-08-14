using System;
class Area {
  static void Main() {
    int base_1, altura;
    double perimetro, area;
    
    Console.WriteLine("Digite a base \n");
    base_1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite a altura\n");
    altura = int.Parse(Console.ReadLine());
    
    area = base_1 * altura;
    perimetro = (base_1 * 2) + (altura * 2);
    
    Console.WriteLine("A area: " +area);
    Console.WriteLine("O perimetro: " +perimetro);
  }
}
  
