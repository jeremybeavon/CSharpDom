using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewAnonymousArrayExpression : AbstractExpression, INewAnonymousArrayExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousArrayExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
