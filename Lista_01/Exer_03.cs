using System;

namespace Lista_01_Exer_03
{
    class Exer_03
    {
        static void Main(string[] args)
        {
            int num;
            int soma=0;

            Console.WriteLine("Digite três números: ");
            for (int x = 0; x < 3; x++) {
            num = int.Parse(Console.ReadLine());
            soma += num; }
            Console.WriteLine(soma);
        }
    }
}
