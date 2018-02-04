using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableMethodCallExpression<TExpression> :
        IEditableMethodCallExpression,
        IMethodCallExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }

        new IList<TExpression> ParameterExpressions { get; set; }
    }
}