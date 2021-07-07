using System;

namespace Exer_04
{
    class Exer_04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros:");
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int maior = num > num1 ? num : num1;
            int menor = num < num1 ? num : num1;

            Console.WriteLine("O maior valor é "+maior+"\nPossui diferença de "+(maior-menor));
        }
    }
}
