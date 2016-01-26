using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression>
        where TCreateObjectExpression : ICreateObjectExpression
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        TCreateObjectExpression CreateObjectExpression { get; }

        IReadOnlyCollection<TBinaryOperatorExpression> Members { get; }
    }
}
