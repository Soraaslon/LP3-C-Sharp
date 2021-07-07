using System;

namespace Exer_14
{
    class Exer_14
    {
        static void Main(string[] args)
        {
            float A, B, C;

            Console.WriteLine("Digite os valores de ABC:");
            A = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());
            C = float.Parse(Console.ReadLine());

            if (A<(B+C) && B < (A + C) && C < (A + B))
            {
                if (A.Equals(B) && B.Equals(C))
                    Console.WriteLine("É um triângulo equilátero");
                else if(A.Equals(B)|| A.Equals(C) || B.Equals(C))
                    Console.WriteLine("É um triângulo isóscele");
                else
                    Console.WriteLine("É um triângulo escaleno");
            } else
                Console.WriteLine("Não é um triângulo");
        }
    }
}
