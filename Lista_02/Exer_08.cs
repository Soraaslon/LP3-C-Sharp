using System;

namespace Exer_08
{
    class Exer_08
    {
        static void Main(string[] args)
        {
            float altura, pesoIdeal;
            char genero;

            Console.WriteLine("Digite seu sexo, 'M' para Homem e 'F' para Mulher: ");
            genero = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            
            if (genero == 'M')
                pesoIdeal = (72.7f*altura)-58f;
            else
                pesoIdeal = (62.1f * altura)-44.7f;

            Console.WriteLine("O seu peso ideal é " + pesoIdeal);
        }
    }
}
