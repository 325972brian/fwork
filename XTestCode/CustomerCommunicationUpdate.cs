/// <summary>
/// Update command of selected CustomerCommunication object (row of table CustomerCommunication).
/// </summary>
public class CustomerCommunicationUpdate
{
	/// <summary>
	/// CostumerCommunication id.
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
	/// Communication description.
	/// </summary>
	public string? Description { get; set; }

	/// <summary>
	/// Indicated wether the Communication is used.
	/// </summary>
	public bool IsActive { get; set; }
}