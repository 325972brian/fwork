namespace Warehouse.Application.Models.CommunicationModel
{
    /// <summary>
    /// Update command of selected communication object (row of table communication).
    /// </summary>
    public class CommunicationUpdate
    {
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
        public string? NumberExtension { get; set; }

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
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        public string? Fax { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The website url.
        /// </summary>
        public string? Website { get; set; }

        /// <summary>
        /// The address type of house or building.
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Communication description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Indicated wether the Communication is used.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
