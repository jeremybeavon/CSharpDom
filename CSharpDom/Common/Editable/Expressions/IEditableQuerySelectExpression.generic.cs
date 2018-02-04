using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQuerySelectExpression<TExpression> :
        IEditableQuerySelectExpression,
        IQuerySelectExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}