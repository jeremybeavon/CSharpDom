using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableNewExpression<TTypeReference, TExpression> :
        IEditableNewExpression,
        INewExpression<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        new TTypeReference Type { get; set; }

        new IList<TExpression> Parameters { get; set; }
    }
}