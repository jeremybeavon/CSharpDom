using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryFromExpression<TExpression> :
        IEditableQueryFromExpression,
        IQueryFromExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new string Identifier { get; set; }

        new TExpression Expression { get; set; }
    }
}