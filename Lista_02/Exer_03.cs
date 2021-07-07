using System;

namespace Exer_03
{
    class Exer_03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O número é "+((num % 2 == 0) ? "par" : "impar"));
        }
    }
}
