using System;

namespace Exer_05
{
    class Exer_05
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());
            if (num < 0)
                num = 0;
            while (!(num % 11 == 0 || num % 13 == 0 || num % 17 == 0))
            {
                num++;
            }
            Console.WriteLine("O múltiplo de 11, 13 ou 17 mais próximo é: "+num);
        }
    }
}
