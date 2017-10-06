using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableOutExpression<TExpression> : AbstractExpression, IOutExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutExpressionChildren(this, visitor);
        }
    }
}
