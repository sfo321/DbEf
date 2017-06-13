using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class RecipeConfiguration : EntityTypeConfiguration<Recipe>
    {
        internal RecipeConfiguration()
        {
            this.HasKey(t => t.Id)
                .HasMany(i => i.RecipeIngredients)
                .WithMany(r => r.Recipes);
            this.HasMany(p => p.Pizzas);
            this.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("Index") { IsUnique = true }));        }
    }
}
