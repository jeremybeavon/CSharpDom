using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableArrayIndexExpression<TExpression> :
        IEditableArrayIndexExpression,
        IArrayIndexExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Array { get; set; }

        new IList<TExpression> Indexes { get; set; }
    }
}