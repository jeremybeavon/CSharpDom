using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IExpressionStatement<TExpression> : IExpressionStatement
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
