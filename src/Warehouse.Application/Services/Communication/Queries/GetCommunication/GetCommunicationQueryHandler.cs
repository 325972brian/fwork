using MediatR;
using Warehouse.Application.Exceptions;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Models.CommunicationModel;

namespace Warehouse.Application.Services.Communication.Queries.GetCommunication
{
    /// <summary>
    /// Get the selected Communication query handler.
    /// </summary>
    public class GetCommunicationQueryHandler : IRequestHandler<GetCommunicationQuery, CommunicationView>
    {
        /// <summary>
        /// Dependency of ICommunicationRepository.
        /// </summary>
        private readonly ICommunicationRepository _communicationRepository;

        /// <summary>
        /// Constructor of GetCommunicationQueryHandler.
        /// </summary>
        /// <param name="communicationRepository"></param>
        public GetCommunicationQueryHandler(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        /// <summary>
        /// Get the communication by Id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<CommunicationView> Handle(GetCommunicationQuery request, CancellationToken cancellationToken)
        {
            // Get the selected communication object by Id.
            var selectedCommunication = await _communicationRepository.GetByIdAsync(request.Id);

            //var selectedCommunication = await _communicationRepository.FindByConditionQueryable(com => com.Id == request.Id).FirstOrDefault();

            if (selectedCommunication == null)
            {
                throw new NotFoundException(nameof(selectedCommunication), request.Id);
            }

            var communication = new CommunicationView
            {
                Id                  = selectedCommunication.Id,
                Street              = selectedCommunication.Street,
                Number              = selectedCommunication.Number,
                NumberExtension     = selectedCommunication.NumberExtension,
                ZipCode             = selectedCommunication.ZipCode,
                Place               = selectedCommunication.Place,
                Province            = selectedCommunication.Province,
                Phone               = selectedCommunication.Phone,
                Mobile              = selectedCommunication.Mobile,
                Fax                 = selectedCommunication.Fax,
                Email               = selectedCommunication.Email,
                Website             = selectedCommunication.Website,
                AddressType         = selectedCommunication.AddressType,
                Communicationkey    = selectedCommunication.Communicationkey,
                Description         = selectedCommunication.Description,
                IsActive            = selectedCommunication.IsActive,
                DateCreated         = selectedCommunication.DateCreated,
                DateModified        = selectedCommunication.DateModified,
                DateExpired         = selectedCommunication.DateExpired,
                Timestamp           = selectedCommunication.Timestamp,

                // Set view model state based on user permissions
                EditEnabled = true,
                DeleteEnabled = true,
            };

            return await Task.Run(() => communication);
        }
    }
}
