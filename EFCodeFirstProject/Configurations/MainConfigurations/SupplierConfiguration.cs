using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class SupplierConfiguration : EntityTypeConfiguration<Supplier>
    {
        internal SupplierConfiguration()
        {
            this.HasKey(s => s.Id)
                .Property(s => s.Name)
                .HasMaxLength(30)
                .IsRequired()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("Index") { IsUnique = true }));
            this.Property(s => s.Category)
                .IsRequired();
        }
    }
}
