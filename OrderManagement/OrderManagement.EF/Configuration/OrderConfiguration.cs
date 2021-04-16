using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.EF.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o =>o.OrderCode ).HasMaxLength(20).IsRequired();
            builder.Property(o =>o.ProductCode ).HasMaxLength(20).IsRequired();
            builder.Property(o =>o.OrderDate).HasMaxLength(20).IsRequired();
            builder.HasOne(o => o.Client).WithMany(c => c.Orders);
            
        }
    
    }
}
