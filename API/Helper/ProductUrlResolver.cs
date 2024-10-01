

using API.Dto;
using AutoMapper;
using Core.Entities;

namespace API.Helper
{
    public class ProductUrlResolver : IValueResolver<Product, ProductToReturnDto, string>//src , Destination, Destination property
    {
        private readonly IConfiguration _config;

        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product product, ProductToReturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(product.PictureUrl)) {
                return _config["ApiUrl"]+product.PictureUrl;
            }

            return null;
        }
    }
}
