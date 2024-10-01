using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Specifications;
namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecifications<T>
    {
        public BaseSpecification()
        {
        }

        public BaseSpecification(Expression<Func<T, bool>> condition)
        {
            Condition = condition;
        }

        public List<Expression<Func<T, object>>> Includes { get; } = 
            new List<Expression<Func<T, object>>>();

       public Expression<Func<T, bool>> Condition { get; }
       public void AddInclude(Expression<Func<T, object>> expression) { 
        Includes.Add(expression);
        }
    }
}
