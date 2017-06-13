using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class PizzaConfiguration : EntityTypeConfiguration<Pizza>
    {
        internal PizzaConfiguration()
        {
            this.HasKey(p => p.Id)
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("Index") { IsUnique = true } ));
            this.Property(p => p.Price)
                .IsRequired();
            this.Property(p => p.Weight)
                .IsRequired();
            this.Property(p => p.Quantity)
                .IsRequired();
            this.HasRequired(p => p.Recipe);
        }
    }
}
