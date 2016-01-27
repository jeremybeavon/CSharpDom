using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IWhileStatement<TExpression, TStatement> : IWhileStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Condition { get; }
        TStatement Statement { get; }
    }
}
