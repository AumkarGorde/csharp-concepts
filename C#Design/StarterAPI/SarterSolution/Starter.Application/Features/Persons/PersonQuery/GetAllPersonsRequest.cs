using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Application.Features.Persons.PersonQuery
{
    public sealed record GetAllPersonsRequest: IRequest<List<Domain.Entities.Person>>;
}
