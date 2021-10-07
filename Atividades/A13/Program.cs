using System;

namespace Atividade_13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área da forma: " + forma.calcularArea() +"\n");
        }

        static void Main(string[] args)
        {
            IForma forma = new Quadrado(10.0);
            mostrarArea(forma);

            forma = new Retangulo(5.0, 7.5);
            mostrarArea(forma);

            forma = new Triangulo(6.23, 8);
            mostrarArea(forma);

            forma = new Circulo(4.5);
            mostrarArea(forma);

        }
    }
}
