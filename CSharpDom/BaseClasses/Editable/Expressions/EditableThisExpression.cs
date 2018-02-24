using System;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableThisExpression : EditableExpression, IEditableThisExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitThisExpression(this);
        }

        public override void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitThisExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
