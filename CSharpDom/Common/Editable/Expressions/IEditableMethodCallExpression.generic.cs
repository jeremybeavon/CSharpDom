using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableMethodCallExpression<TExpression, TTypeReference, TArgument> :
        IEditableMethodCallExpression,
        IMethodCallExpression<TExpression, TTypeReference, TArgument>
        where TExpression : IEditableExpression
        where TTypeReference : IEditableTypeReference
        where TArgument : IEditableArgument
    {
        new TExpression Expression { get; set; }

        new IList<TTypeReference> GenericParameters { get; set; }

        new IList<TArgument> Parameters { get; set; }
    }
}