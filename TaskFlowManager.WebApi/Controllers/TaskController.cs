using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskFlowManager.WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("v{version:ApiVersion}/[controller]")]
    public class TaskController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        public async Task<IActionResult> GetTasks(CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
