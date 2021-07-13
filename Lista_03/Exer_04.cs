using System;

namespace Exer_04
{
    class Exer_04
    {
        static void Main(string[] args)
        {
            int num, impar=1;
            Console.WriteLine("Quantos números impares deseja ver: ");
            num = int.Parse(Console.ReadLine());

            for (int x=0; x < num;x++)
            {
                Console.WriteLine(impar);
                impar += 2;
            }
        }
    }
}
