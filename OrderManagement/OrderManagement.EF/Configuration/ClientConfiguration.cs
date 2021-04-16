using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.EF.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.ClientCode).HasMaxLength(150).IsRequired();
            builder.Property(b => b.Firstname).HasMaxLength(1000).IsRequired();
            builder.Property(b => b.Lastname).HasMaxLength(1000).IsRequired();
            builder.HasMany(b => b.Orders).WithOne(o => o.Client);
            
        }
    
    }
}
