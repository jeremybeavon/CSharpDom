using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.Editable.Expressions
{
    public abstract class EditableDoubleConstantExpression : AbstractExpression, IDoubleConstantExpression
    {
        public abstract double Constant { get; set; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
