using System;

namespace Exer_03
{
    class Exer_03
    {
        static void Main(string[] args)
        {
            float num=0;
            Console.WriteLine("Digite 10 valores: ");
            for (int x = 0; x < 10; x++)
            {
                num += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("A soma dos valores é: "+num);
        }
    }
}
