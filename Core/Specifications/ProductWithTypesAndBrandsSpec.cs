    using Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    namespace Core.Specifications
    {
        public class ProductWithTypesAndBrandsSpec : BaseSpecification<Product>
        {
            public ProductWithTypesAndBrandsSpec()
            {
                AddInclude(x => x.ProductType);
                AddInclude(x => x.ProductBrand);
            
            }
        public ProductWithTypesAndBrandsSpec(string sort)
        {
            AddInclude(p => p.ProductType);
            AddInclude(p => p.ProductBrand);
            AddOrderBy(p => p.Name); // Default sorting by name

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort.ToLower())
                {
                    case "priceasc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "pricedesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    case "nameasc":
                        AddOrderBy(p => p.Name);
                        break;
                    case "namedesc":
                        AddOrderByDescending(p => p.Name);
                        break;
                    default:
                        AddOrderBy(p => p.Name);
                        break;
                }
            }
        }
        public ProductWithTypesAndBrandsSpec(int id) : base(x=>x.Id==id)
            {
                AddInclude(x => x.ProductType);
                AddInclude(x => x.ProductBrand);
            }
        }
    }
