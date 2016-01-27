using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IUsingStatement<TExpression, TStatement> : IUsingStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Expression { get; }

        TStatement Statement { get; }
    }
}
