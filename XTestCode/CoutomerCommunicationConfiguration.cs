/// <summary>
/// Configure the CustomerCommunication table.
/// </summary>
public class CustomerCommunicationConfiguration : IEntityTypeConfiguration<CostumerCommunicationEntity>
{
	/// <summary>
	/// CustomerCommunication columns configuration.
	/// </summary>
	/// <param name="builder"></param>
	public void Configure(EntityTypeBuilder<CustomerCommunicationEntity> builder)
	{
		builder.ToTable("CustomerCommunication");
		builder.HasKey(cc => cc.Id);

		builder.Property(cc => cc.Id)
			   .HasColumnName("Id");
			   
		builder.Property(cc => cc.CustomerId)
			   .HasColumnName("CustomerId")
			   .IsRequired(true);
			   
		builder.Property(cc => cc.CommunicationId)
			   .HasColumnName("CommunicationId")
			   .IsRequired(true);

		builder.Property(cc => cc.CostumerCommunicationkey)
				.ValueGeneratedNever()
				.IsRequired(true);

		builder.Property(cc => cc.IsActive)
				.IsRequired(true);

		builder.Property(cc => cc.Description)
				.IsRequired(false)
				.HasMaxLength(200);

		builder.Property(cc => cc.DateCreated)
				.IsRequired(true);

		builder.Property(cc => cc.DateModified)
				.IsRequired(true);

		builder.Property(cc => cc.DateExpired)
				.IsRequired(true)
				.ValueGeneratedOnAddOrUpdate() // here is the computed query definition
				.HasComputedColumnSql("CASE WHEN[IsActive] = 1 THEN CONVERT(DATETIME2, '9999-12-31 00:00:00.0000000') ELSE CONVERT(DATETIME2, SYSDATETIME()) END");

		builder.Property(cc => cc.Timestamp)
				.IsRequired(true)
				.ValueGeneratedOnAddOrUpdate()
				.HasColumnType("rowversion");
				
		// builder.HasOne(cc => cc.Customer)
				// .WithMany(c => c.CustomerCommnication)
				// .HasForeignkey(cc => cc.CustomerId)
				// .OnDelete(DeleteBehavior.ClientcSetNull)
				// .HasConstraintName("FK_CustomerCommnication_Customer");
				
		builder.HasOne(cc => cc.Commnication)
				.WithMany(c => c.CustomerCommnication)
				.HasForeignkey(cc => cc.CommnicationId)
				.OnDelete(DeleteBehavior.ClientcSetNull)
				.HasConstraintName("FK_CustomerCommnication_Commnication");
	}
}