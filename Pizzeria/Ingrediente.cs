using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class Ingrediente :IIngrediente
    {
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public bool PericoloAllergeni { get; set; }
        public bool Surgelato { get; set; }
    }
}
