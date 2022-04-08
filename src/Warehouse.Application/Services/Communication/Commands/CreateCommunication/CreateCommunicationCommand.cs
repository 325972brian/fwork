using MediatR;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Commands.CreateCommunication
{
    /// <summary>
    /// Command creation of communication.
    /// </summary>
    public class CreateCommunicationCommand : IRequest<int>
    {
        /// <summary>
        /// Command creation request of communication.
        /// </summary>
        public CommunicationCreate? CommunicationCreateRequest { get; set; }
    }
}
