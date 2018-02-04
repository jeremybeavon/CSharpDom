using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableQueryJoinExpression<TExpression> :
        IEditableQueryJoinExpression,
        IQueryJoinExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new string JoinVariable { get; set; }

        new TExpression InExpression { get; set; }

        new TExpression OnExpression { get; set; }

        new TExpression EqualsExpression { get; set; }

        new string IntoVariable { get; set; }
    }
}