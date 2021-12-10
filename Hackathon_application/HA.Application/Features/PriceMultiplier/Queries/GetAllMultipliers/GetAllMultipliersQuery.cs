using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers
{
    public class GetAllMultipliersQuery : IRequest<List<MultiplierListVm>>
    {
    }
}
