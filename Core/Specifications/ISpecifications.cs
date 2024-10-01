using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecifications<T>
    {
        List<Expression<Func<T,object>>> Includes {  get; } 
        Expression<Func<T, bool>> Condition { get; }

    }
}
