using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryGroupExpression<TExpression> :
        IEditableQueryGroupExpression,
        IQueryGroupExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression GroupExpression { get; set; }

        new TExpression ByExpression { get; set; }
    }
}