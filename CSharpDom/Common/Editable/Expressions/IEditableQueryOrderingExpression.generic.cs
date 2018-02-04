using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryOrderingExpression<TExpression> :
        IEditableQueryOrderingExpression,
        IQueryOrderingExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }

        new QueryOrderByType OrderByType { get; set; }
    }
}