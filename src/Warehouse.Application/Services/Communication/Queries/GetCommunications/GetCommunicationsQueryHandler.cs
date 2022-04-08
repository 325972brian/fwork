using MediatR;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Queries.GetCommunications
{
    /// <summary>
    /// Get the all communication command handler.
    /// </summary>
    public class GetCommunicationsQueryHandler : IRequestHandler<GetCommunicationsQuery, CommunicationListView>
    {
        /// <summary>
        /// Dependency of ICommunicationRepository.
        /// </summary>
        private readonly ICommunicationRepository _communicationRepository;

        /// <summary>
        /// Constructor of GetCommunicationsQueryHandler.
        /// </summary>
        /// <param name="communicationRepository"></param>
        public GetCommunicationsQueryHandler(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        /// <summary>
        /// Get all the communications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CommunicationListView> Handle(GetCommunicationsQuery request, CancellationToken cancellationToken)
        {
            // Get all rows from communication table.
            var communications = await _communicationRepository.GetAllAsync();

            // Check whether the list is empty.
            if (communications == null)
            {
                throw new ArgumentNullException(nameof(communications));
            }

            // Convert the communications entity list to communication view model list.
            var resultList = new List<CommunicationView>(communications.Select(lCommuication => new CommunicationView
            {
                Id                  = lCommuication.Id,
                Street              = lCommuication.Street,
                Number              = lCommuication.Number,
                NumberExtension     = lCommuication.NumberExtension,
                ZipCode             = lCommuication.ZipCode,
                Place               = lCommuication.Place,
                Province            = lCommuication.Province,
                Phone               = lCommuication.Phone,
                Mobile              = lCommuication.Mobile,
                Fax                 = lCommuication.Fax,
                Email               = lCommuication.Email,
                Website             = lCommuication.Website,
                AddressType         = lCommuication.AddressType,
                Communicationkey    = lCommuication.Communicationkey,
                Description         = lCommuication.Description,
                IsActive            = lCommuication.IsActive,
                DateCreated         = lCommuication.DateCreated,
                DateModified        = lCommuication.DateModified,
                DateExpired         = lCommuication.DateExpired,
                Timestamp           = lCommuication.Timestamp,
            }).ToList());

            var resultCommunications = new CommunicationListView
            {
                Communications = resultList,
                CreateEnabled = true
            };

            return await Task.Run(() => resultCommunications);
        }
    }
}
