using System;

namespace Lista_01_Exer_07
{
    class Exer_07
    {
        static void Main(string[] args)
        {
            float celsius;
            float fahrenheit;
            Console.WriteLine("Digite os graus fahrenheit: ");
            fahrenheit = float.Parse(Console.ReadLine());
            celsius = 5*(fahrenheit -32)/9;
            Console.WriteLine(celsius);
        }
    }
}
