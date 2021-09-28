using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Mamifero:Animal
    {
        public Mamifero(){
            Console.Write("Mamifero -> ");
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("Mamíferos possuem pele, pelo e cabelo");
        }
    }
}
