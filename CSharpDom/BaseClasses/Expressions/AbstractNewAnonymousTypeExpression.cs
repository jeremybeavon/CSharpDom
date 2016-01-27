using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractNewAnonymousTypeExpression : INewAnonymousTypeExpression
    {
        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitNewAnonymousTypeExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
        }
    }
}
