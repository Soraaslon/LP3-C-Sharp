using System;

namespace Exer_13
{
    class Exer_13
    {
        static void Main(string[] args)
        {
            float baseMenor, baseMaior, altura, area;

            Console.WriteLine("Digite o valor da base menor (maior que 0)");
            baseMenor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base maior (maior que 0)");
            baseMaior = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura");
            altura = float.Parse(Console.ReadLine());

            if (baseMenor>0 && baseMaior> 0) { 
            area = ((baseMenor + baseMaior) * altura)/2;
            Console.WriteLine("A área é: " + area);}
        }
    }
}
