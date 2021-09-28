using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Jacare:Reptil
    {
        public Jacare(){
            Console.WriteLine("Jacare");
            this.cobertura();
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("Esse é casca grossa kkkk, possuem escamas córneas\n");
        }
    }
}
