using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractIdentifierExpression : AbstractExpression, IIdentifierExpression
    {
        public abstract string Name { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitIdentifierExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
