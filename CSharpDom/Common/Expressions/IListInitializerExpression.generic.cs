using System.Collections.Generic;

namespace CSharpDom.Common.Expressions
{
    public interface IListInitializerExpression<TCreateListExpression, TExpression> : IListInitializerExpression
        where TCreateListExpression : ICreateListExpression
        where TExpression : IExpression
    {
        TCreateListExpression CreateListExpression { get; }

        IReadOnlyList<IReadOnlyList<TExpression>> InitialValues { get; }
    }
}
