using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using pizza_mama_v1.Data;
using pizza_mama_v1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_mama_v1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext dataContext;

        // Le framework instancie la class avec les paramètres, dataContext est configuré dans --> Startup.cs
        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public void OnGet()
        {
            //var pizza = new Pizza() { nom = "PizzaTest", prix = 5 };
            //dataContext.Pizzas.Add(pizza);
            //dataContext.SaveChanges();
        }
    }
}
