namespace Warehouse.Domain.Entities
{
    /// <summary>
    /// CustomerCommunication entity.
    /// </summary>
    public class CustomerCommunicationEntity
    {
        /// <summary>
        /// Constructor of CustomerCommunication entity.
        /// </summary>
        public CustomerCommunicationEntity() { }

        /// <summary>
        /// CustomerCommunication id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Customer id.
        /// </summary>
        public int CustomerId { get; set; }

		/// <summary>
		/// Communication id.
		/// </summary>
		public int CommunicationId { get; set; }

		/// <summary>
		/// Internal key id of CustomerCommunication. 
		/// </summary>
		public Guid CustomerCommunicationkey { get; set; }

		/// <summary>
		/// Communication description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Indicated wether the Communication is used.
		/// </summary>
		public bool IsActive { get; set; }

		/// <summary>
		/// Creation date of Communication.
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// Modification date of Communication.
		/// </summary>
		public DateTime DateModified { get; set; }

		/// <summary>
		/// Expiration date of Communication.
		/// </summary>
		public DateTime DateExpired { get; set; }

		/// <summary>
		/// Modification number of database table record.
		/// </summary>
		public byte[] Timestamp { get; set; }

		/// Navigation object to Customer.
		/// </summary>
		//public CustomerEntity Customer { get; set; }

		/// Navigation object to Communication.
		/// </summary>
		public CommunicationEntity Communication { get; set; }



	}
}
