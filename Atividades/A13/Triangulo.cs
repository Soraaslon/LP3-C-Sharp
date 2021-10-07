using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_13
{
    class Triangulo:IForma
    {
        private double basezinha;
        private double altura;

        public Triangulo(double basezinha, double altura)
        {
            this.basezinha = basezinha;
            this.altura = altura;
        }

        public double calcularArea()
        {
            return (this.basezinha * this.altura) / 2;
        }
    }
}
