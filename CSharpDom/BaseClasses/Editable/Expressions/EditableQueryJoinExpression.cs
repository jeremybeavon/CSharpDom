using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableQueryJoinExpression<TExpression> :
        EditableExpression,
        IEditableQueryJoinExpression<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression EqualsExpression { get; set; }

        public abstract TExpression InExpression { get; set; }

        public abstract string IntoVariable { get; set; }

        public abstract string JoinVariable { get; set; }

        public abstract TExpression OnExpression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryJoinExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
