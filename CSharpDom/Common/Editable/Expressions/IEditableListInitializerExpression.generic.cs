using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableListInitializerExpression<TCreateListExpression, TExpression> :
        IEditableListInitializerExpression,
        IListInitializerExpression<TCreateListExpression, TExpression>
        where TCreateListExpression : IEditableCreateListExpression
        where TExpression : IEditableExpression
    {
        new TCreateListExpression CreateListExpression { get; set; }

        new IList<IList<TExpression>> InitialValues { get; set; }
    }
}