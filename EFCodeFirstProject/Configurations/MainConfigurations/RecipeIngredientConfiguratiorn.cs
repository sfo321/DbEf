using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class RecipeIngredientConfiguration : EntityTypeConfiguration<RecipeIngredient>
    {
        internal RecipeIngredientConfiguration()
        {
            this.HasKey(i => i.Id)
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
