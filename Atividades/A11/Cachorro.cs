using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Cachorro:Mamifero
    {
        public Cachorro(){
            Console.WriteLine("Cachorro");
            this.cobertura();
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("Cachorros possuem diferentes tipos de pelagem, e fazem auau\n");
        }
    }
}
