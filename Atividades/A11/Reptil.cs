using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Reptil:Animal
    {
        public Reptil(){
            Console.Write("Reptil -> ");
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("Os répteis possuem escamas");
        }
    }
}
