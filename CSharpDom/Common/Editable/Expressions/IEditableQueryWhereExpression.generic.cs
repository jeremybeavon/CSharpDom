using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryWhereExpression<TExpression> :
        IEditableQueryWhereExpression,
        IQueryWhereExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression Expression { get; set; }
    }
}