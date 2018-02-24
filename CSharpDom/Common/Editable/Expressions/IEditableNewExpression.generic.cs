using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableNewExpression<TTypeReference, TArgument> :
        IEditableNewExpression,
        INewExpression<TTypeReference, TArgument>
        where TTypeReference : IEditableTypeReference
        where TArgument : IEditableArgument
    {
        new TTypeReference Type { get; set; }

        new IList<TArgument> Parameters { get; set; }
    }
}