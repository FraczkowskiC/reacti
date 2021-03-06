using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;

        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Activity>>> List()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}