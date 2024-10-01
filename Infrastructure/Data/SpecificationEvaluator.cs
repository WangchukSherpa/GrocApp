using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntities
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery,
            ISpecifications<TEntity> spec)
        { 
            var query = inputQuery.AsQueryable();
            if (spec.Condition != null) { 
            query= query.Where(spec.Condition);//p=>p.ProductTypeId=id
            }
            query = spec.Includes.Aggregate(query,(current,include)=>current.Include(include));
            return query;
        }
    }
}
