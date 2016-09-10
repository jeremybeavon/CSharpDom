using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryGroupExpressionWithCodeAnalysis<TExpression, TIdentifierExpression> :
        IQueryGroupExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TExpression ByExpression { get; set; }

        public abstract TExpression GroupExpression { get; set; }

        public abstract TIdentifierExpression IntoExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryGroupExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryGroupExpressionChildren(this, visitor);
        }
    }
}
