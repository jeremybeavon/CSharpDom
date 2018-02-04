using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryOrderByExpression<TOrderingExpression> :
        IEditableQueryOrderByExpression,
        IQueryOrderByExpression<TOrderingExpression>
        where TOrderingExpression : IEditableQueryOrderingExpression
    {
        new IList<TOrderingExpression> Orders { get; set; }
    }
}