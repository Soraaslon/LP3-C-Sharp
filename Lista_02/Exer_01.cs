using System;

namespace Exer_01
{
    class Exer_01
    {
        static void Main(string[] args)
        {
            int num;
            int num1;

            Console.WriteLine("Digite dois números inteiros:");
            num = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());

            if (num > num1)
                Console.WriteLine("O maior número é: "+num);
            else
                Console.WriteLine("O maior número é: "+ num1);
        }
    }
}
