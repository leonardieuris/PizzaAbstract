using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class PizzaMargherita : Pizza
    {
        public PizzaMargherita(double prezzo) : base(prezzo)
        {
            var mozzarella = new Ingrediente();
            mozzarella.Prezzo = 1;
            mozzarella.Descrizione = "Mozzarella";
            mozzarella.PericoloAllergeni = true;
            mozzarella.Surgelato = false;

            var salsadipomodoro = new Ingrediente
            {
                Prezzo = 0.50,
                Descrizione = "Salsa di pomodoro",
                PericoloAllergeni = false,
                Surgelato = true

            };

            listaIngredienti.Add(mozzarella);
            listaIngredienti.Add(salsadipomodoro);
            PrezzoBase = 3.50;
        }

        public override string Nome()
        {
            return  "Prizza Margherita";
        }
    }
}
