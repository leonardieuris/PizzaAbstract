using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Calzone : Pizza
    {
        public Calzone() : base(2, Pizzeria.TipoPizza.Normale)
        {
        }

        public override string Nome() => "Calzone";
    }
}
