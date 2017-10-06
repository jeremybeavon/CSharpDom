using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableRefExpression<TExpression> : AbstractExpression, IRefExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRefExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitRefExpressionChildren(this, visitor);
        }
    }
}
