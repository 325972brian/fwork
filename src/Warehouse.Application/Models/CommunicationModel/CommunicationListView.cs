namespace Warehouse.Application.Models.CommunicationModel
{
    /// <summary>
    /// Communication list viewModel.
    /// </summary>
    public class CommunicationListView
    {
        /// <summary>
        /// Get all Communication
        /// </summary>
        public IEnumerable<CommunicationView>? Communications { get; set; }

        /// <summary>
        /// Is the list created.
        /// </summary>
        public bool CreateEnabled { get; set; }
    }
}
