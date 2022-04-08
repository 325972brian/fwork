using Warehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Warehouse.Infrastructure.Configurations
{
    /// <summary>
    /// Configure the CustomerCommunication table.
    /// </summary>
    public class CustomerCommunicationConfiguration : IEntityTypeConfiguration<CustomerCommunicationEntity>
    {
        /// <summary>
        /// CostumerCommunication columns configuration.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<CustomerCommunicationEntity> builder)
        {
            builder.ToTable("CustomerCommunication");

            // Thie is a primrykey
            builder.HasKey(cus => cus.Id);

            builder.Property(cus => cus.Id)
                   .HasColumnName("Id");

            builder.Property(cus => cus.CustomerId)
                   .HasColumnName("CustomerId")
                   .IsRequired(true);

            builder.Property(cus => cus.CommunicationId)
                   .HasColumnName("CommunicationId")
                   .IsRequired(true);

            builder.Property(cus => cus.CustomerCommunicationkey)
                    .ValueGeneratedNever()
                    .IsRequired(true);

            builder.Property(cus => cus.IsActive)
                   .IsRequired(true);

            builder.Property(cus => cus.Description)
                    .IsRequired(false)
                    .HasMaxLength(200);

            builder.Property(cus => cus.DateCreated)
                   .IsRequired(true);

            builder.Property(cus => cus.DateModified)
                   .IsRequired(true);

            builder.Property(cus => cus.DateExpired)
                   .IsRequired(true)
                   .ValueGeneratedOnAddOrUpdate() // here is the computed query definition
                   .HasComputedColumnSql("CASE WHEN[IsActive] = 1 THEN CONVERT(DATETIME2, '9999-12-31 00:00:00.0000000') ELSE CONVERT(DATETIME2, SYSDATETIME()) END");

            builder.Property(cus => cus.Timestamp)
                    .IsRequired(true)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("rowversion");

            //builder.HasOne(cc => cc.Customer)
            //        .WithMany(c => c.CustomerCommnication)
            //        .HasForeignkey(cc => cc.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientcSetNull)
            //        .HasConstraintName("FK_CustomerCommnication_Customer");

            builder.HasOne(cus => cus.Communication)
                    .WithMany(c => c.CustomerCommunicationList)
                    .HasForeignKey(cus => cus.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerCommunication_Communication");
        }
    }
}
