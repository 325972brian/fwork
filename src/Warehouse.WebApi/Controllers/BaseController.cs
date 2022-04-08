using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Warehouse.WebApi.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]/[action]")]
    public abstract class BaseController : Controller
    {
        private IMediator _mediator;

        protected BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
