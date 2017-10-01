using System;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractRawExpression : AbstractExpression, IRawExpression
    {
        public abstract string Expression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRawExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
