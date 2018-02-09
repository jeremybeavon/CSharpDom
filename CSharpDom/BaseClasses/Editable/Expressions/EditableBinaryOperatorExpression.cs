using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableBinaryOperatorExpression<TExpression> :
        EditableExpression,
        IEditableBinaryOperatorExpression<TExpression>
        where TExpression : IEditableExpression
    {
        public abstract TExpression Left { get; set; }

        public abstract BinaryOperatorExpressionType OperatorType { get; set; }

        public abstract TExpression Right { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
