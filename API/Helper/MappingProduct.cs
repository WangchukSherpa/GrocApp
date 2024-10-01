using API.Dto;
using AutoMapper;
using Core.Entities;

namespace API.Helper
{
    public class MappingProduct: Profile
    {
        public MappingProduct() {
        CreateMap<Product,ProductToReturnDto>()

        .ForMember(destination=>destination.ProductBrand,
        option=>option.MapFrom(s=>s.ProductBrand.Name))

        .ForMember(destinationMember=> destinationMember.ProductType,
        option=>option.MapFrom(s=>s.ProductType))
        
        .ForMember(destinationMember=> destinationMember.PictureUrl,
        option=>option.MapFrom<ProductUrlResolver>());
        }
       
    }
}
