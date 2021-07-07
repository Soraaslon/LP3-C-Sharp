using System;

namespace Exer_15
{
    class Exer_15
    {
        static void Main(string[] args)
        {
            int idade, tempoS;

            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu tempo de serviço em anos: ");
            tempoS = int.Parse(Console.ReadLine());

            if (idade >= 65 || tempoS >= 30){
                Console.WriteLine("Você pode se aposentar");
            } else if (idade >= 60 && tempoS >= 25)
                Console.WriteLine("Você pode se aposentar");
            else
                Console.WriteLine("Você não pode se aposentar");
        }
    }
}
