using System;
class prog4
{
    static void Main(){
        int quantidade_eleitores, nulos, brancos, validos;
        double percentual_nulos, percentual_brancos, percentual_validos;
        
        Console.WriteLine("Digite a quantidade total de eleitores");
        quantidade_eleitores = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de votos nulos");
        nulos = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a quantidade de votos brancos");
        brancos = int.Parse(Console.ReadLine());
      
        Console.WriteLine("Digite a quantidade de votos validos");
        validos = int.Parse(Console.ReadLine());
        
        percentual_nulos = ((nulos * 100.0)/quantidade_eleitores);
        percentual_brancos = ((brancos * 100.0)/quantidade_eleitores);
        percentual_validos =  ((validos * 100.0)/quantidade_eleitores);
        
        Console.WriteLine("O percentual de votos nulos: " + percentual_nulos);
        Console.WriteLine("O percentual de votos brancos: " + percentual_brancos);
        Console.WriteLine("O percentual de votos validos: " + percentual_validos);
   }
}
