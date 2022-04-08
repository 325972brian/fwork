using MediatR;
using Warehouse.Domain.Entities;
using Warehouse.Application.Interfaces;

namespace Warehouse.Application.Services.Communication.Commands.CreateCommunication
{
    /// <summary>
    /// Create communication command handler.
    /// </summary>
    public class CreateCommunicationCommandHandler : IRequestHandler<CreateCommunicationCommand, int>
    {
        /// <summary>
        /// Dependency of ICommunicationRepository.
        /// </summary>
        private readonly ICommunicationRepository _communicationRepository;

        /// <summary>
        /// Constructor of CreateCommunicationCommandHandler.
        /// </summary>
        /// <param name="communicationRepository"></param>
        public CreateCommunicationCommandHandler(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        /// <summary>
        /// Create a new communication object (Row in teble communication).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> Handle(CreateCommunicationCommand request, CancellationToken cancellationToken)
        {
            var createRequest = request.CommunicationCreateRequest;

            // Check whether the command is empty.
            if (createRequest == null)
            {
                throw new ArgumentNullException(nameof(createRequest));
            }

            var newCommunication = new CommunicationEntity
            {
                Street              = createRequest.Street,
                Number              = createRequest.Number,
                NumberExtension     = createRequest.NumberExtension ?? String.Empty,
                ZipCode             = createRequest.ZipCode,
                Place               = createRequest.Place,
                Province            = createRequest.Province,
                Phone               = createRequest.Phone ?? String.Empty,
                Mobile              = createRequest.Mobile,
                Fax                 = createRequest.Fax ?? String.Empty,
                Email               = createRequest.Email,
                Website             = createRequest.Website ?? String.Empty,
                AddressType         = createRequest.AddressType,
                Description         = createRequest.Description ?? String.Empty,
                Communicationkey    = Guid.NewGuid(),
                IsActive            = createRequest.IsActive,
                DateCreated         = DateTime.Now,
                DateModified        = DateTime.Now,
            };

            await _communicationRepository.AddNewObjectAsync(newCommunication, cancellationToken);
            return newCommunication.Id;
        }
    }
}
