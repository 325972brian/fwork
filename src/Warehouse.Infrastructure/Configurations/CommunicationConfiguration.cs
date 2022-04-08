using Warehouse.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Warehouse.Infrastructure.Configurations
{
    /// <summary>
    /// Configure the Communication table.
    /// </summary>
    public class CommunicationConfiguration : IEntityTypeConfiguration<CommunicationEntity>
    {
        /// <summary>
        /// Communication columns configuration.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<CommunicationEntity> builder)
        {
            builder.ToTable("Communication");
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => new { c.ZipCode, c.Place });

            builder.Property(i => i.Id)
                   .HasColumnName("Id");

            builder.Property(e => e.Street)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Number)
                    .IsRequired(true)
                    .HasMaxLength(10);

            builder.Property(e => e.NumberExtension)
                    .IsRequired(false)
                    .HasMaxLength(10);

            builder.Property(e => e.ZipCode)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Place)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Province)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Phone)
                    .IsRequired(false)
                    .HasMaxLength(50);

            builder.Property(i => i.Mobile)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Fax)
                    .IsRequired(false)
                    .HasMaxLength(50);

            builder.Property(e => e.Email)
                    .IsRequired(true)
                    .HasMaxLength(50);

            builder.Property(e => e.Website)
                    .IsRequired(false)
                    .HasMaxLength(50);

            builder.Property(e => e.AddressType)
                    .IsRequired(true)
                    .HasMaxLength(100);

            builder.Property(e => e.Communicationkey)
                    .ValueGeneratedNever()
                    .IsRequired(true);

            builder.Property(e => e.IsActive)
                    .IsRequired(true);

            builder.Property(e => e.Description)
                    .IsRequired(false)
                    .HasMaxLength(200);

            builder.Property(e => e.DateCreated)
                    .IsRequired(true);

            builder.Property(e => e.DateModified)
                    .IsRequired(true);

            builder.Property(e => e.DateExpired)
                    .IsRequired(true)
                    .ValueGeneratedOnAddOrUpdate() // here is the computed query definition
                    .HasComputedColumnSql("CASE WHEN[IsActive] = 1 THEN CONVERT(DATETIME2, '9999-12-31 00:00:00.0000000') ELSE CONVERT(DATETIME2, SYSDATETIME()) END");

            builder.Property(e => e.Timestamp)
                    .IsRequired(true)
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("rowversion");
        }
    }
}
