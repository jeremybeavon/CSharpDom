using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryOrderByExpressionWithCodeAnalysis<TExpression> : IQueryOrderByExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public abstract QueryOrderByType OrderByType { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryOrderByExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryOrderByExpressionChildren(this, visitor);
        }
    }
}
