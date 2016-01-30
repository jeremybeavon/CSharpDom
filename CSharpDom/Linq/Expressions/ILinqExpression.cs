using CSharpDom.Common.Expressions;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public interface ILinqExpression : IExpression
    {
        Expression Expression { get; }
    }
}
