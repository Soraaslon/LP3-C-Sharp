using System;

namespace Exer_06
{
    class Exer_06
    {
        static void Main(string[] args)
        {
            int num, menor, maior;
            Console.WriteLine("Digite números inteiros, e um negativo para sair");
            menor = maior = num = int.Parse(Console.ReadLine());
            if (num >= 0) {
                while (num >= 0)
                {
                    if (num < menor)
                    {
                        menor = num;
                    }
                    else if (num > maior)
                        maior = num;
                    num = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("O maior número é: "+maior+"\nO menor número é: "+menor);
            }
        }
    }
}
