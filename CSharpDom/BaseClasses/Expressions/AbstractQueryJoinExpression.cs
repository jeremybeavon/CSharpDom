using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryJoinExpression<TExpression, TIdentifierExpression> :
        IQueryJoinExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TExpression EqualsExpression { get; }

        public abstract TExpression InExpression { get; }

        public abstract TIdentifierExpression IntoExpression { get; }

        public abstract TIdentifierExpression JoinExpression { get; }

        public abstract TExpression OnExpression { get; }

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
