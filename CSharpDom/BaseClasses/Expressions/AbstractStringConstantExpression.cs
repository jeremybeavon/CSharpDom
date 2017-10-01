using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractStringConstantExpression : AbstractExpression, IStringConstantExpression
    {
        public abstract string Constant { get; }

        public abstract bool HasAtSymbol { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitStringConstantExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
