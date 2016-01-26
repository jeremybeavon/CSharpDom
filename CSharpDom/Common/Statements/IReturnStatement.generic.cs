using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IReturnStatement<TExpression> : IReturnStatement
        where TExpression : IExpression
    {
        TExpression Expression { get; }
    }
}
