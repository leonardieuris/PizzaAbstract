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
        protected TipoPizza _tipoPizza;

        public Pizza(double prezzo,TipoPizza tipoPizza)
        {
            PrezzoBase = prezzo;
            _tipoPizza = tipoPizza;
        }

        public string TipoPizza() => _tipoPizza switch
        {
            Pizzeria.TipoPizza.Baby => "Pizza Baby",
            Pizzeria.TipoPizza.Family => "Pizza Family",
            Pizzeria.TipoPizza.Normale => "Normal"
        };



        private float TipoPizzaPrezzo()
        {
            return _tipoPizza switch
            {
                Pizzeria.TipoPizza.Baby => 0.5f,
                Pizzeria.TipoPizza.Family => 2.0f,
                Pizzeria.TipoPizza.Normale => 1.0f,
            };
        }

        public double Prezzo()
        {
            var prezzoFinale = PrezzoBase;

            foreach (var ingrediente in listaIngredienti)
            {
                prezzoFinale += ingrediente.Prezzo;
            }
            return prezzoFinale*TipoPizzaPrezzo();
        }

        public void AggiungiIngrediente(IIngrediente ingrediente)
        {
            listaIngredienti.Add(ingrediente);
        }

        public abstract string Nome();
    }
}
