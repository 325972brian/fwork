using MediatR;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Queries.GetCommunication
{
    /// <summary>
    /// Communication query.
    /// </summary>
    public class GetCommunicationQuery : IRequest<CommunicationView>
    {
        /// <summary>
        /// Communication Id.
        /// </summary>
        public int Id { get; set; }
    }
}
