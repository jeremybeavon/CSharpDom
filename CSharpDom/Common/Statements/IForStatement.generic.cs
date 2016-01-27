using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Statements
{
    public interface IForStatement<TExpression, TForInitializerStatement, TStatement> : IForStatement
        where TExpression : IExpression
        where TForInitializerStatement : IForInitializerStatement
        where TStatement : IStatement
    {
        TForInitializerStatement InitialValueStatement { get; }

        TExpression Condition { get; }

        IReadOnlyCollection<TExpression> IncrementExpressions { get; }

        TStatement Statement { get; }
    }
}
