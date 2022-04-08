using MediatR;
using Warehouse.Application.Exceptions;
using Warehouse.Application.Interfaces;

namespace Warehouse.Application.Services.Communication.Commands.UpdateCommunication
{
    /// <summary>
    /// Update command handler of communication.
    /// </summary>
    public class UpdateCommunicationCommandHandler : IRequestHandler<UpdateCommunicationCommand, Unit>
    {
        /// <summary>
        /// Dependency of ICommunicationRepository.
        /// </summary>
        private readonly ICommunicationRepository _communicationRepository;

        /// <summary>
        /// Constructor of UpdateCommunicationCommandHandler.
        /// </summary>
        /// <param name="communicationRepository"></param>
        public UpdateCommunicationCommandHandler(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        /// <summary>
        /// Update a selected communication object (Update a selected row of communication table)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Unit> Handle(UpdateCommunicationCommand request, CancellationToken cancellationToken)
        { 
            // Get the selected communication object form user interface (Page)
            var updateRequest = request.CommunicationUpdateRequest;

            // Check whether the command is empty.
            if (updateRequest == null)
            {
                throw new ArgumentNullException(nameof(updateRequest));
            }

            // Get the selected communication row form communication table in database.
            var selectedCommunication = await _communicationRepository.GetByIdAsync(updateRequest.Id);
            
            // Check whether the selected communication object (Row of table communication) is existing.
            if (selectedCommunication == null)
            {
                throw new NotFoundException(nameof(selectedCommunication), updateRequest.Id);
            }

            selectedCommunication.Street            = updateRequest.Street;
            selectedCommunication.Number            = updateRequest.Number;
            selectedCommunication.NumberExtension   = updateRequest.NumberExtension ?? String.Empty;
            selectedCommunication.ZipCode           = updateRequest.ZipCode;
            selectedCommunication.Place             = updateRequest.Place;
            selectedCommunication.Province          = updateRequest.Province;
            selectedCommunication.Phone             = updateRequest.Phone ?? String.Empty;
            selectedCommunication.Mobile            = updateRequest.Mobile;
            selectedCommunication.Fax               = updateRequest.Fax ?? String.Empty;
            selectedCommunication.Email             = updateRequest.Email;  
            selectedCommunication.Website           = updateRequest.Website ?? String.Empty;
            selectedCommunication.AddressType       = updateRequest.AddressType ?? String.Empty;
            selectedCommunication.Description       = updateRequest.Description ?? String.Empty;
            selectedCommunication.IsActive          = updateRequest.IsActive;
            selectedCommunication.DateModified      = DateTime.Now;

            await _communicationRepository.UpdateObjectAsync(selectedCommunication, cancellationToken);

            return Unit.Value;
        }
    }
}
