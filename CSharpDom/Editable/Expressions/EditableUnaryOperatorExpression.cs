using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableUnaryOperatorExpression<TExpression> :
        AbstractExpression,
        IUnaryOperatorExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Operand { get; set; }

        public abstract UnaryOperatorExpressionType OperatorType { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitUnaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitUnaryOperatorExpressionChildren(this, visitor);
        }
    }
}
