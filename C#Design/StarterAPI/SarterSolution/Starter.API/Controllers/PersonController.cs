using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Starter.Application.Features.Person.PersonCommands;
using Starter.Application.Features.Persons.PersonQuery;
using Starter.Domain.Entities;

namespace Starter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult<Person>> Create(AddPersonCommandRequest addPerson, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(addPerson, cancellationToken);
            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllPersonsRequest(), cancellationToken);
            return Ok(response);
        }
    }
}
