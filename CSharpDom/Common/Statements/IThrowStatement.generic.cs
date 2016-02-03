using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IThrowStatement<TExpression> : IThrowStatement
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
