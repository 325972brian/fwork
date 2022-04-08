using MediatR;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Queries.GetCommunications
{
    public class GetCommunicationsQuery : IRequest<CommunicationListView>
    {
    }
}
