using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstProject.Models
{
    public class Ingredient
    {
        public Ingredient()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int ActualQuantity { get; set; }

        public int PendingQuantity { get; set; }

        public IngredientCategories Category { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public virtual RecipeIngredient RecipeIngredient { get; set; }
    }
}
