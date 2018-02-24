using System;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractThisExpression : AbstractExpression, IThisExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitThisExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
