using System;

namespace Exer_02
{
    class Exer_02
    {
        static void Main(string[] args)
        {
            float num;

            Console.WriteLine("Digite um número positivo:");
            num = float.Parse(Console.ReadLine());
            if (num >= 0) {
                Console.WriteLine(num+" ao quadrado é "+num*num);
                Console.WriteLine("Raíz de " + num + " é " + Math.Sqrt(num));
            } else
                Console.WriteLine("Não era positivo");

        }
    }
}
