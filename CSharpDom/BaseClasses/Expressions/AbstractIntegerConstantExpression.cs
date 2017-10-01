using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractIntegerConstantExpression : AbstractExpression, IIntegerConstantExpression
    {
        public abstract int Constant { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIntegerConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
