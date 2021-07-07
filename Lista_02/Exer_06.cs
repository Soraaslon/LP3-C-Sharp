using System;

namespace Exer_06
{
    class Exer_06
    {
        static void Main(string[] args)
        {
            float nota1;
            float nota2;

            Console.WriteLine("Digite duas notas, de 0 a 10: ");
            nota1 = float.Parse(Console.ReadLine());
            nota2 = float.Parse(Console.ReadLine());

            if ((nota1>=0&&nota1<=10) && (nota2 >= 0 && nota2 <= 10))
            {
                float media = (nota1 + nota2) / 2;
                Console.WriteLine("A média é: "+media);
            } else
            {
                Console.WriteLine("Um dos valores informados é inválido");
            }
           
        }
    }
}
