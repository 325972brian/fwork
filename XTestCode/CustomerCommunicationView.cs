public class CustomerCommunicationView
{
	///// <summary>
	///// Constructor of CustomerCommunicationView.
	///// </summary>
	//public CommunicationView() { }

	/// <summary>
	/// CustomerCommunication id.
	/// </summary>
	public int Id { get; set; }
	
	/// <summary>
	/// Reference to Costumer id(Foreignkey).
	/// </summary>
	public int CustomerId { get; set; }
	
	/// <summary>
	/// Reference to CommunicationId id (Foreignkey).
	/// </summary>
	public int CommunicationId { get; set; }

	/// <summary>
	/// Internal key id of CostumerCommunication. 
	/// </summary>
	public Guid CostumerCommunicationkey { get; set; }

	/// <summary>
	/// CostumerCommunication description.
	/// </summary>
	[StringLength(200, ErrorMessage = "Description text is too long.")]
	public string? Description { get; set; }

	/// <summary>
	/// Indicated wether the CostumerCommunication is used.
	/// </summary>
	public bool IsActive { get; set; }

	/// <summary>
	/// Creation date of CostumerCommunication.
	/// </summary>
	[DataType(DataType.Date)]
	public DateTime DateCreated { get; set; }

	/// <summary>
	/// Modification date of CostumerCommunication.
	/// </summary>
	[DataType(DataType.Date)]
	public DateTime DateModified { get; set; }

	/// <summary>
	/// Expiration date of CostumerCommunication.
	/// </summary>
	[DataType(DataType.Date)]
	public DateTime DateExpired { get; set; }

	/// <summary>
	/// Modification number of database table record.
	/// </summary>
	public byte[] Timestamp { get; set; }

	/// <summary>
	/// Edit state bassed on user permission
	/// </summary>
	public bool EditEnabled { get; set; }

	/// <summary>
	/// Delete state bassed on user permission
	/// </summary>
	public bool DeleteEnabled { get; set; }
}