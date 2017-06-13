using EFCodeFirstProject.Contracts;
using EFCodeFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstProject
{
    public class Start
    {
        static void Main()
        {
            var context = new MainDbContext();
            var data = new Data<Supplier>(context);

            var supplier = new Supplier()
            {
                Name = "Milk Fact LTD",
                Category = IngredientCategories.MilkProducts
            };

            data.Insert(supplier);
            context.SaveChanges();
        }
    }
}
