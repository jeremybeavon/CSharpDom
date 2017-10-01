using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableTernaryOperatorExpression<TExpression> :
        AbstractExpression,
        ITernaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Left { get; set; }

        public abstract TExpression Middle { get; set; }

        public abstract TExpression Right { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitTernaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitTernaryOperatorExpressionChildren(this, visitor);
        }
    }
}
