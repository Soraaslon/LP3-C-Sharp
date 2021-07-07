using System;

namespace Exer_05
{
    class Exer_05
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros:");
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (num > num1){
                Console.WriteLine("O maior valor é: "+num);
            }else if (num < num1){
                Console.WriteLine("O maior valor é: " + num1);
            } else {
                Console.WriteLine("Os valores são iguais");
            }
        }
    }
}
