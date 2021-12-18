using AutoMapper;
using MediatR;
using ShopiOrderingApp.Application.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace ShopiOrderingApp.Application.Feature
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, ServiceResponse<GetOrderByIdViewModel>>
    {
        IOrderRepository orderRepository;
        private readonly IMapper mapper;

        public GetOrderByIdHandler(IOrderRepository orderRepository ,IMapper mapper)
        {
            this.orderRepository = orderRepository;
            this.mapper = mapper;
        }

        
        public async Task<ServiceResponse<GetOrderByIdViewModel>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await orderRepository.GetById(request.Id);

            var dto = mapper.Map<GetOrderByIdViewModel>(order);

            return new ServiceResponse<GetOrderByIdViewModel>(dto);
        }
    }
}
