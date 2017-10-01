using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractDoubleConstantExpression : AbstractExpression, IDoubleConstantExpression
    {
        public abstract double Constant { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitDoubleConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
