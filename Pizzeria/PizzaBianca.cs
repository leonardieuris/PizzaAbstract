namespace Pizzeria;

public class PizzaBianca : Pizza
{
    public PizzaBianca(double prezzo) : base(prezzo)
    {
        var mozzarella = new Ingrediente();
        mozzarella.Prezzo = 1;
        mozzarella.Descrizione = "Mozzarella";
        mozzarella.PericoloAllergeni = true;
        mozzarella.Surgelato = false;

        listaIngredienti.Add(mozzarella);
        PrezzoBase = 2.50;
    }

    public override string Nome()
    {
        return  "Pizza Bianca";
    }
}