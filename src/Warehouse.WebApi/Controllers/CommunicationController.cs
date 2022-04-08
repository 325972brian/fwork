using MediatR;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Application.Models.CommunicationModel;
using Warehouse.Application.Services.Communication.Queries.GetCommunication;
using Warehouse.Application.Services.Communication.Queries.GetCommunications;
using Warehouse.Application.Services.Communication.Commands.CreateCommunication;
using Warehouse.Application.Services.Communication.Commands.UpdateCommunication;
using Warehouse.Application.Services.Communication.Commands.DeleteCommunication;

namespace Warehouse.WebApi.Controllers
{
    /// <summary>
    /// Warehouse communication controller.
    /// </summary>
    [ApiController]
    [Produces("application/json")]
    public class CommunicationController : BaseController
    {
        public CommunicationController(IMediator mediator) : base(mediator){}

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CommunicationListView>> GetAll()
        {
            return Ok(await Mediator.Send(new GetCommunicationsQuery()));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CommunicationView>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetCommunicationQuery{ Id = id }));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<int>> Create([FromBody] CommunicationCreate newCommunication)
        {
            var command            = new CreateCommunicationCommand { CommunicationCreateRequest = newCommunication };
            var commuincationNewId = await Mediator.Send(command);
            return Ok(commuincationNewId);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update([FromBody] CommunicationUpdate selectedCommunication)
        {
            var command = new UpdateCommunicationCommand { CommunicationUpdateRequest = selectedCommunication };
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            await Mediator.Send(new DeleteCommunicationCommand { Id = id });
            return NoContent();
        }
    }
}
