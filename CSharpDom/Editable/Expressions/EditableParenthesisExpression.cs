using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableParenthesisExpression<TExpression> :
        AbstractExpression,
        IParenthesisExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitParenthesisExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitParenthesisExpressionChildren(this, visitor);
        }
    }
}
