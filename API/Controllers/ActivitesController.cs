using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Activites;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ActivitesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivitesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> List()
        {
            return await _mediator.Send(new List.Query());
        }
    }
}