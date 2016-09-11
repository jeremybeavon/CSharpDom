using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryLetExpressionWithCodeAnalysis<TBinaryOperatorExpression> :
        IQueryLetExpression<TBinaryOperatorExpression>
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        public abstract TBinaryOperatorExpression Expression { get; set; }

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
