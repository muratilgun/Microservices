using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FreeCourse.Services.Order.Application.Dtos;
using FreeCourse.Services.Order.Application.Queries;
using FreeCourse.Shared.Dtos;
using MediatR;

namespace FreeCourse.Services.Order.Application.Handlers
{
    public class GetOrdersByUserIdQueryHandler : IRequestHandler<GetOrdersByUserIdQuery,Response<List<OrderDto>>>
    {
        public async Task<Response<List<OrderDto>>> Handle(GetOrdersByUserIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
