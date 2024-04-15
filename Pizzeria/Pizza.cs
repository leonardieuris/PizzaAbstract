using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Pizza : IPizza
    {

        protected List<IIngrediente> listaIngredienti = new List<IIngrediente>();

        protected double PrezzoBase;

        public Pizza(double prezzo)
        {
            PrezzoBase = prezzo;
        }
        

        public double Prezzo()
        {
            var prezzoFinale = PrezzoBase;

            foreach (var ingrediente in listaIngredienti)
            {
                prezzoFinale += ingrediente.Prezzo;
            }
            return prezzoFinale;
        }

        public void AggiungiIngrediente(IIngrediente ingrediente)
        {
            listaIngredienti.Add(ingrediente);
        }

        public abstract string Nome();
    }
}
