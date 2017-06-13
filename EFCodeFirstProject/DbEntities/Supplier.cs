using System;
using System.Collections.Generic;
using System.Text;

namespace EFCodeFirstProject.Models
{
    public class Supplier
    {
        public Supplier()
        {
            this.Orders = new HashSet<Order>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public IngredientCategories Category { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
