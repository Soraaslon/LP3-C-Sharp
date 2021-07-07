using System;

namespace Exer_07
{
    class Exer_07
    {
        static void Main(string[] args)
        {
            float sal, emp;
            Console.WriteLine("Digite o valor do seu sálario: ");
            sal=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do empréstimo: ");
            emp = float.Parse(Console.ReadLine());
            Console.WriteLine("Empréstimo " + (emp > sal * 0.20f ? "Concedido" : "Não Concedido"));

        }
    }
}
