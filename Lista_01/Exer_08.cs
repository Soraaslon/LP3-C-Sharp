using System;

namespace Lista_01_Exer_08
{
    class Exer_08
    {
        static void Main(string[] args)
        {
            double celsius;
            double kelvin;
            Console.WriteLine("Digite os graus kelvin: ");
            kelvin = double.Parse(Console.ReadLine());
            celsius = kelvin - 273.15;
            Console.WriteLine(celsius);
        }
    }
}
