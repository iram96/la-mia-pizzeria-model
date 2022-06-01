namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string Nome { get; set; }

        public string Desc { get; set; }

        public int Prezzo { get; set; }
        public Pizza(string Nome, string Desc, int Prezzo)
        {
            this.Nome = Nome;
            this.Desc = Desc;
            this.Prezzo = Prezzo;
        }

    }

    public class pizzaList
    {
        public List<Pizza> ListaPizze { get; set; }

        public pizzaList()
        {
            ListaPizze = new();

        }
    }
}
