namespace Warehouse.Application.Models.CustomerCommunicationModel
{
    public class CustomerCommunicationListView
    {
		/// <summary>
		/// Get all CostumerCommunications
		/// </summary>
		public IEnumerable<CustomerCommunicationView>? CustomerCommunications { get; set; }

		/// <summary>
		/// Is the list created.
		/// </summary>
		public bool CreateEnabled { get; set; }
	}
}
