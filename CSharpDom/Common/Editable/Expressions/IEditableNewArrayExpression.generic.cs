using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableNewArrayExpression<TTypeReference, TExpression> :
        IEditableNewArrayExpression,
        INewArrayExpression<TTypeReference, TExpression>
        where TTypeReference : IEditableTypeReference
        where TExpression : IEditableExpression
    {
        new TTypeReference ElementType { get; set; }

        new IList<int> Dimensions { get; set; }

        new IList<TExpression> InitialSizeExpressions { get; set; }
    }
}