using System.ComponentModel.DataAnnotations;

namespace pizza_mama_v1.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Display(Name = "Prix (€)")]
        public float prix { get; set; }

        // Affiche le display name Végétarienne au lieu du nom du champs vegetarienne
        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        [Display(Name = "Ingrédients")]
        public string ingredients { get; set; }
    }
}
