using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Expressions
{
    public abstract class EditableDoubleConstantExpression : AbstractExpression, IEditableDoubleConstantExpression
    {
        public abstract double Constant { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public void Accept(IEditableExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }

        public void AcceptChildren(IEditableExpressionVisitor visitor)
        {
        }
    }
}
