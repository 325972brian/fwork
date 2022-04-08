namespace Warehouse.Application.Models.CustomerCommunicationModel
{
    public class CostumerCommunicationCreate
    {
		/// <summary>
		/// Customer id.
		/// </summary>
		public int CustomerId { get; set; }

		/// <summary>
		/// Communication id.
		/// </summary>
		public int CommunicationId { get; set; }

		/// <summary>
		/// CostumerCommunication description.
		/// </summary>
		public string? Description { get; set; }

		/// <summary>
		/// Indicated wether the CostumerCommunication is used.
		/// </summary>
		public bool IsActive { get; set; }
	}
}
