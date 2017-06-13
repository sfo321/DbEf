using System;
using System.Collections.Generic;

namespace EFCodeFirstProject.Models
{
    public class Order
    {
        public Order()
        {
            this.Ingredients = new HashSet<Ingredient>();
        }

        public int Id { get; set; }

        public DateTime DeliveryDate { get; set; }

        public OrderStatus Status { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
