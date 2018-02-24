using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableArrayIndexExpression<TExpression, TArgument> :
        IEditableArrayIndexExpression,
        IArrayIndexExpression<TExpression, TArgument>
        where TExpression : IEditableExpression
        where TArgument : IEditableArgument
    {
        new TExpression Array { get; set; }

        new IList<TArgument> Indexes { get; set; }
    }
}