using System;

namespace Exer_09
{
    class Exer_09
    {
        static void Main(string[] args)
        {
            int num;
            string nums;

            Console.WriteLine("Digite um número inteiro maior que 0: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                nums = num.ToString();
                num = 0;
                for (int x = 0; x < nums.Length; x++)
                    num += int.Parse(nums.Substring(x,1));

                Console.WriteLine("Soma dos algarismos: " + num);
            } else
                Console.WriteLine("Número inválido");
        }
    }
}
