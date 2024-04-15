namespace Pizzeria;

public interface IIngrediente
{
    string Descrizione { get; set; }
    double Prezzo { get; set; }
    bool PericoloAllergeni { get; set; }
    bool Surgelato { get; set; }
}