using MediatR;
using Starter.Application.Features.Person.PersonCommands;
using Starter.Application.Repositories;
using Starter.Application.Repositories.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Application.Features.Persons.PersonCommands
{
    public class AddPersonCommandHandler : IRequestHandler<AddPersonCommandRequest, Domain.Entities.Person>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IUnitOfWork _unitOfWork;
        public AddPersonCommandHandler(IPersonRepository personRepository, IUnitOfWork unitOfWork)
        {
            _personRepository = personRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Domain.Entities.Person> Handle(AddPersonCommandRequest addPersonCommand, CancellationToken cancellationToken)
        {
            var newPerson = new Domain.Entities.Person()
            {
                FirstName = addPersonCommand.FirstName,
                LastName = addPersonCommand.LastName,
                Age = addPersonCommand.Age
            };
            await _personRepository.AddAsync(newPerson);
            await _unitOfWork.SaveChangesAsync();

            return newPerson;
        }
    }
}
