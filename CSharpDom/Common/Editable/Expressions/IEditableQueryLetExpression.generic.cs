using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryLetExpression<TExpression> :
        IEditableQueryLetExpression,
        IQueryLetExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new string Identifier { get; set; }

        new TExpression Expression { get; set; }
    }
}