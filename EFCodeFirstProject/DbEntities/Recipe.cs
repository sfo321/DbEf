using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstProject.Models
{
    public class Recipe
    {
        public Recipe()
        {
            this.Pizzas = new HashSet<Pizza>();
            this.RecipeIngredients = new HashSet<RecipeIngredient>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Pizza> Pizzas { get; set; }

        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; }
    }
}