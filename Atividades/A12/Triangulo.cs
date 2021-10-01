using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_12
{
    class Triangulo:Forma
    {
        private double basezinha;
        private double altura;

        public Triangulo(double basezinha, double altura)
        {
            base.setCor("Amarelin");
            this.basezinha = basezinha;
            this.altura = altura;
            Console.WriteLine("O perimetro deste triângulo é: " + this.calcularArea());
        }

        public override double calcularArea()
        {
            return (this.basezinha * this.altura) / 2;
        }
    }
}
