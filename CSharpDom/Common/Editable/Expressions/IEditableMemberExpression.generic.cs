using CSharpDom.Common.Expressions;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableMemberExpression<TExpression> : IEditableMemberExpression, IMemberExpression<TExpression>
        where TExpression : IEditableExpression
    {
        new TExpression ObjectExpression { get; set; }

        new string MemberName { get; set; }
    }
}