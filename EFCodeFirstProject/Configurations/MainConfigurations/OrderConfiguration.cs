using EFCodeFirstProject.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace EFCodeFirstProject.Configurations
{
    internal class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        internal OrderConfiguration()
        {
            this.HasKey(o => o.Id)
                .Property(o => o.DeliveryDate)
                .IsRequired();
            this.Property(o => o.Status)
                .IsRequired();
            this.HasRequired(o => o.Supplier);
        }
    }
}
