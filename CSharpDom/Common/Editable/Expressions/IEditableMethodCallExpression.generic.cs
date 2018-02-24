using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableMethodCallExpression<TExpression, TArgument> :
        IEditableMethodCallExpression,
        IMethodCallExpression<TExpression, TArgument>
        where TExpression : IEditableExpression
        where TArgument : IEditableArgument
    {
        new TExpression Expression { get; set; }

        new IList<TArgument> Parameters { get; set; }
    }
}