using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstProject.Models
{
    public class RecipeIngredient
    {
        public RecipeIngredient()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
