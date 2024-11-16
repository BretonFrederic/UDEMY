using Microsoft.EntityFrameworkCore;
using pizza_mama.Models;
using System.Collections.Generic;

namespace pizza_mama.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
