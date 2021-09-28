using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Anfibio:Animal
    {
        public Anfibio(){
            Console.Write("Anfibio -> ");
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("São dois em um, vivem na água e na terra, possuem pele bem úmida, caso ela seque, eles morrem");
        }
    }
}
