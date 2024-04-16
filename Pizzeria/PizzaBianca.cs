namespace Pizzeria;

public class PizzaBianca : Pizza
{
    public PizzaBianca(TipoPizza tipoPizza) : base(2.50,tipoPizza)
    {
        var mozzarella = new Ingrediente();
        mozzarella.Prezzo = 1;
        mozzarella.Descrizione = "Mozzarella";
        mozzarella.PericoloAllergeni = true;
        mozzarella.Surgelato = false;

        listaIngredienti.Add(mozzarella);
    }

    public override string Nome()
    {
        return  "Pizza Bianca";
    }
}