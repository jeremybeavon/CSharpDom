using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Statements
{
    public interface IDoStatement<TExpression, TStatement> : IDoStatement
        where TExpression : IExpression
        where TStatement : IStatement
    {
        TExpression Condition { get; }

        TStatement Statement { get; }
    }
}
