using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Animal
    {
        public Animal(){
            Console.Write("Animal -> ");
        }

        protected virtual void cobertura()
        {
            Console.WriteLine("Todo animal possui uma cobertura em seu corpo");
        }
    }
}
