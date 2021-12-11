using System.Collections.Generic;
using MediatR;

namespace HA.Application.Features.PriceMultiplier.Queries.GetAllMultipliers
{
    public class GetAllMultipliersQuery : IRequest<List<MultiplierListVm>>
    {
    }
}
