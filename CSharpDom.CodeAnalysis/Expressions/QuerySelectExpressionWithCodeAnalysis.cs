using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QuerySelectExpressionWithCodeAnalysis<TExpression> : IQuerySelectExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectExpressionChildren(this, visitor);
        }
    }
}
