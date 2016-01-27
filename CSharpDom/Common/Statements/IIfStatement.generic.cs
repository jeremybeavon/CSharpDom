using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IIfStatement<TExpression, TStatement> : IIfStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Condition { get; }

        TStatement ThenStatement { get; }

        TStatement ElseStatement { get; }
    }
}
