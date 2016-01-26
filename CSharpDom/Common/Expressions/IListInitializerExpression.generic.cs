using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IListInitializerExpression<TCreateListExpression, TExpression>
        where TCreateListExpression : ICreateListExpression
        where TExpression : IExpression
    {
        TCreateListExpression CreateListExpression { get; }

        IReadOnlyList<TExpression> InitialValues { get; }
    }
}
