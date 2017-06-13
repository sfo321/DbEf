using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstProject.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Weight { get; set; }

        public int Quantity { get; set; }

        public virtual Recipe Recipe { get; set; }
    }
}
