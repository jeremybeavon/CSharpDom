using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryWhereExpressionWithCodeAnalysis<TExpression> : IQueryWhereExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryWhereExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryWhereExpressionChildren(this, visitor);
        }
    }
}
