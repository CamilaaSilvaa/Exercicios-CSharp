using System;
class prog5
{
    static void Main(){
        double varA, varB, auxiliar;
        
        Console.WriteLine("Digite o 1 numero");
        varA = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o 2 numero");
        varB = double.Parse(Console.ReadLine());
        
        auxiliar = varA;
        varA = varB;
        varB = auxiliar;
        
        Console.WriteLine("O valor do 1 numero trocado ficou: " + varA);
        Console.WriteLine("O valor do 2 numero trocado ficou: " + varB);
   }
}
