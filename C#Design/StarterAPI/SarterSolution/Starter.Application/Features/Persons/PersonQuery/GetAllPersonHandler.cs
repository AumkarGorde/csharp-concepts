using MediatR;
using Starter.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Application.Features.Persons.PersonQuery
{
    public sealed class GetAllPersonHandler : IRequestHandler<GetAllPersonsRequest, List<Domain.Entities.Person>>
    {
        private readonly IPersonRepository _personRepository;
        public GetAllPersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public async Task<List<Domain.Entities.Person>> Handle(GetAllPersonsRequest request, CancellationToken cancellationToken)
        {
            var persons = await _personRepository.GetAllAsync();
            return persons.ToList();
        }
    }
}
