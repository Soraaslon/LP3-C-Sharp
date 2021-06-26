using System;

namespace Lista_01_Exer_06
{
    class Exer_06
    {
        static void Main(string[] args)
        {
            float celsius;
            float fahrenheit;
            Console.WriteLine("Digite os graus celsius: ");
            celsius = float.Parse(Console.ReadLine());
            fahrenheit = (celsius*9/5)+ 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
