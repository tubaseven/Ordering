using AutoMapper;
using MediatR;
using ShopiOrderingApp.Application.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopiOrderingApp.Application.Feature
{
    public class GetAllOrdersQuery : IRequest<ServiceResponse<List<OrderViewDto>>>
    {


        public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, ServiceResponse<List<OrderViewDto>>>
        {
            private readonly IOrderRepository orderRepository;
            private readonly IMapper mapper;

            public GetAllOrdersQueryHandler(IOrderRepository orderRepository, IMapper mapper)
            {
                this.orderRepository = orderRepository;
                this.mapper = mapper;
            }


            public async Task<ServiceResponse<List<OrderViewDto>>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
            {
                var products = await orderRepository.GetAll();

                var viewModel = mapper.Map<List<OrderViewDto>>(products);

                return new ServiceResponse<List<OrderViewDto>>(viewModel);
            }
        }


    }
}
