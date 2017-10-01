using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewAnonymousTypeExpression : AbstractExpression, INewAnonymousTypeExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousTypeExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
