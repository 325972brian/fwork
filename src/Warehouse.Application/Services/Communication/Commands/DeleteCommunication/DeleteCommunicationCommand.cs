using MediatR;

namespace Warehouse.Application.Services.Communication.Commands.DeleteCommunication
{
    /// <summary>
    /// Delete command of commuincation.
    /// </summary>
    public class DeleteCommunicationCommand : IRequest
    {
        /// <summary>
        /// Reference to communication Id (Primary key)
        /// </summary>
        public int Id { get; set; }
    }
}
