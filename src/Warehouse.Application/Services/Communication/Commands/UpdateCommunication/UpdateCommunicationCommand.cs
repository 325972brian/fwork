using MediatR;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Commands.UpdateCommunication
{
    /// <summary>
    /// Update command of selected communication object (Update selectde row of communication table)
    /// </summary>
    public class UpdateCommunicationCommand : IRequest
    {
        /// <summary>
        /// Update command request of communication.
        /// </summary>
        public CommunicationUpdate? CommunicationUpdateRequest { get; set; }
    }
}
