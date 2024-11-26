using System.ComponentModel.DataAnnotations;

namespace pizza_mama_v1.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string nom { get; set; }
        public float prix { get; set; }

        // Affiche le display name Végétarienne au lieu du nom du champs vegetarienne
        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        public string ingredients { get; set; }
    }
}
