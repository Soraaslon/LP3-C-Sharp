using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Sapo:Anfibio
    {
        public Sapo(){
            Console.WriteLine("Sapo");
            this.cobertura();
        }

        protected override void cobertura()
        {
            base.cobertura();
            Console.WriteLine("Se receber um beijo, quem sabe não vira um príncipe ... mas cuidado com o chulé, a sua cor pode indicar sua letalidade, e não falo do chulé\n");
        }
    }
}
