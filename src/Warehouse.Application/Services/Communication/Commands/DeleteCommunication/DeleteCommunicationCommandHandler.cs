using MediatR;
using Warehouse.Application.Exceptions;
using Warehouse.Application.Interfaces;

namespace Warehouse.Application.Services.Communication.Commands.DeleteCommunication
{
    /// <summary>
    /// Delete command request of commuincation.
    /// </summary>
    public class DeleteCommunicationCommandHandler : IRequestHandler<DeleteCommunicationCommand>
    {
        /// <summary>
        /// Dependency of ICommunicationRepository.
        /// </summary>
        private readonly ICommunicationRepository _communicationRepository;

        /// <summary>
        /// Constructor of DeleteCommunicationCommandHandler.
        /// </summary>
        /// <param name="communicationRepository"></param>
        public DeleteCommunicationCommandHandler(ICommunicationRepository communicationRepository)
        {
            _communicationRepository = communicationRepository;
        }

        /// <summary>
        /// Delete the selected communication object (Seleted row of communication table)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Unit> Handle(DeleteCommunicationCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Get the selected communication object from user interface (page)
                var selectedCommunication = await _communicationRepository.GetByIdAsync(request.Id);

                // Check whether the communication row is empty.
                if (selectedCommunication == null)
                {
                    throw new NotFoundException(nameof(selectedCommunication), $"There is no communication row by id {selectedCommunication.Id}");
                }

                // Delete the selected row from table communication.
                await _communicationRepository.DeleteObjectAsync(selectedCommunication, cancellationToken);

                return Unit.Value;
            }
            catch (DeleteFailureException ex)
            {
                throw new DeleteFailureException(nameof(request), request.Id, $"There is an exception occurred during deleting the selected communication row. {ex}");
            }
        }
    }
}
