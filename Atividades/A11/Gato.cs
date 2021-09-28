using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Gato:Mamifero
    {
        public Gato(){
            Console.WriteLine("Gato");
            this.cobertura();
        }
        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("As cores do pelo de um gato podem dizer muito sobre ele\n");
        }
    }
}
