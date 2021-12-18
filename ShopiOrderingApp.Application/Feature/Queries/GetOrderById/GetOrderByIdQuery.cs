using MediatR;

namespace ShopiOrderingApp.Application.Feature
{
    public class GetOrderByIdQuery : IRequest<ServiceResponse<GetOrderByIdViewModel>>
    {
        public int Id { get; set; }
    }
}
