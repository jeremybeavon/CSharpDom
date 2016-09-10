using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryJoinExpressionWithCodeAnalysis<TExpression, TIdentifierExpression> :
        IQueryJoinExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TExpression EqualsExpression { get; set; }

        public abstract TExpression InExpression { get; set; }

        public abstract TIdentifierExpression IntoExpression { get; set; }

        public abstract TIdentifierExpression JoinExpression { get; set; }

        public abstract TExpression OnExpression { get; set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryJoinExpressionChildren(this, visitor);
        }
    }
}
