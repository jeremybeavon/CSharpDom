using CSharpDom.Common.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public interface ILinqExpression : IExpression, IArgument
    {
        Expression Expression { get; }
    }
}
