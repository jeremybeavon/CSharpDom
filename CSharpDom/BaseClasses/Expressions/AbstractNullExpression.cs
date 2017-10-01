using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNullExpression : AbstractExpression, INullExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNullExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
