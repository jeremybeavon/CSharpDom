using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public interface ILinqExpression<TExpression> : ILinqExpression
        where TExpression : Expression
    {
        new TExpression Expression { get; }
    }
}
