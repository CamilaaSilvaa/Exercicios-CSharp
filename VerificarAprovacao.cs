using System;
class VerificarAprovacao {
  static void Main() {
     float n1, n2, n3, final, faltas;
    bool result;
    
    n1 = float.Parse(Console.ReadLine());
    n2 = float.Parse(Console.ReadLine());
    n3 = float.Parse(Console.ReadLine());
    
    final = n1+n2+n3;
    faltas = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Nota alcançada " + (final >= 60));
    Console.WriteLine("Presença alcançada" + (faltas <= 0.25));
    
    result = (final >=60 && faltas <= 0.25);
    Console.WriteLine("Aluno aprovado: " + result);
  }
  
}
