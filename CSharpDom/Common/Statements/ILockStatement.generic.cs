using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface ILockStatement<TExpression, TStatement> : ILockStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Expression { get; }

        TStatement Statement { get; }
    }
}
