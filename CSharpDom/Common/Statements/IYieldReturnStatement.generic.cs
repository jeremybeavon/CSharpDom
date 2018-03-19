using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IYieldReturnStatement<TExpression> : IYieldReturnStatement
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
