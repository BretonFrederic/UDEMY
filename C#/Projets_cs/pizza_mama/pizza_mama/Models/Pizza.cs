namespace pizza_mama.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string nom { get; set; }
        public float prix { get; set; }
        public bool vegetarienne { get; set; }
        // On aurait pu créer une class ingredients avec un ID pizza
        // pour simplifier la liste d'ingrédients se trouve dans une string
        public string ingredients { get; set; }
    }
}
