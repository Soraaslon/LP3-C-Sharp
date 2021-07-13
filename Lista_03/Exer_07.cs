using System;

namespace Exer_07
{
    class Exer_07
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número par positivo: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Esses são os pares de 0 até "+num);
            for (int x = 0; x <= num; x++) //poderia fazer somar de 2 em 2, e assim tirar o if reduzindo processamento, ou existe algum problema em fazer isso?
                if (x % 2 == 0)
                    Console.WriteLine(x);
        }
    }
}
