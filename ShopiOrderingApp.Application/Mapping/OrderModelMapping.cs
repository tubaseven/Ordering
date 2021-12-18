using AutoMapper;
using ShopiOrderingApp.Application.Feature;
using ShopiOrderingApp.Domain;

namespace ShopiOrderingApp.Application.Mapping
{
    public class OrderModelMapping : Profile
    {
        public OrderModelMapping()
        {
            CreateMap<Order, OrderViewDto>()
                .ReverseMap();

            //CreateMap<Domain.Entities.Product, CreateProductCommand>()
            //    .ReverseMap();

            CreateMap<Order, GetOrderByIdViewModel>()
                .ReverseMap();
        }
    }
}
