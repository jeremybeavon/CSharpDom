using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryLetExpression<TBinaryOperatorExpression> :
        IQueryLetExpression<TBinaryOperatorExpression>
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        public abstract TBinaryOperatorExpression Expression { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryLetExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryLetExpressionChildren(this, visitor);
        }
    }
}
