namespace Warehouse.Domain.Entities
{
    /// <summary>
    /// Communication entity.
    /// </summary>
    public class CommunicationEntity
    {
        /// <summary>
        /// Constructor of Communication entity.
        /// </summary>
        public CommunicationEntity()
        {
            CustomerCommunicationList = new HashSet<CustomerCommunicationEntity>();
            //ShipperCommunicationList  = new HashSet<ShipperCommunicationEntity>();
        }

        /// <summary>
        /// Communication id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The street name of house or building.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// The street number of house or building.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The street number extension of house or building.
        /// </summary>
        public string NumberExtension { get; set; }

        /// <summary>
        /// The street zipCode of house or building.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// The street place of house or building.
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// The province city of house or building.
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The website url.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The address type of house or building.
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Internal key id of Communication. 
        /// </summary>
        public Guid Communicationkey { get; set; }

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

        /// <summary>
        /// List of customer which belong to Communication.
        /// </summary>
        public ICollection<CustomerCommunicationEntity> CustomerCommunicationList { get; set; }

        /// <summary>
        /// List of Shipper which belong to Communication.
        /// </summary>
        //public ICollection<ShipperCommunicationEntity> ShipperCommunicationList { get; set; }
    }
}
