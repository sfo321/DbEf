using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class IngredientConfiguration : EntityTypeConfiguration<Ingredient>
    {
        internal IngredientConfiguration()
        {
            this.HasKey(i => i.Id)
                .HasMany(o => o.Orders)
                .WithMany(i => i.Ingredients);
            this.HasOptional(r => r.RecipeIngredient)
                .WithRequired(i => i.Ingredient);
            this.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("Index") { IsUnique = true }));
            this.Property(p => p.Price)
                .IsRequired();
            this.Property(p => p.Category)
                .IsRequired();
            this.Property(p => p.ActualQuantity)
                .IsRequired();
        }
    }
}
