using System.ComponentModel.DataAnnotations;

namespace Warehouse.Application.Models.CommunicationModel
{
    public class CommunicationView
    {
        ///// <summary>
        ///// Constructor of CommunicationViewModel.
        ///// </summary>
        //public CommunicationView() { }

        /// <summary>
        /// Communication id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The street name of house or building.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        /// <summary>
        /// The street number of house or building.
        /// </summary>
        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        /// <summary>
        /// The street number extension of house or building.
        /// </summary>
        [StringLength(10)]
        public string? NumberExtension { get; set; }

        /// <summary>
        /// The street zipCode of house or building.
        /// </summary>
        [Required]
        [StringLength(7)]
        public string ZipCode { get; set; }

        /// <summary>
        /// The street place of house or building.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Place { get; set; }

        /// <summary>
        /// The province city of house or building.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        /// <summary>
        /// The phone number.
        /// </summary>
        [Phone]
        public string? Phone { get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        [Required]
        [Phone]
        public string Mobile { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [Phone]
        public string? Fax { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// The website url.
        /// </summary>
        [StringLength(50)]
        public string? Website { get; set; }

        /// <summary>
        /// The address type of house or building.
        /// </summary>
        [Required]
        public string AddressType { get; set; }

        /// <summary>
        /// Internal key id of Communication. 
        /// </summary>
        public Guid Communicationkey { get; set; }

        /// <summary>
        /// Communication description.
        /// </summary>
        [StringLength(200, ErrorMessage = "Description text is too long.")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicated wether the Communication is used.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Creation date of Communication.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Modification date of Communication.
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Expiration date of Communication.
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
}
