using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_12
{
    class Circulo:Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("Redzão");
            this.raio = raio;
            Console.WriteLine("O perimetro deste circulo é: "+this.calcularArea());
        }

        public override double calcularArea()
        {
            return (2 * Math.PI)*this.raio;        
        }
    }
}
