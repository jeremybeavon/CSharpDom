using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQuerySelectIntoExpression<TExpression, TIdentifierExpression> :
        AbstractQuerySelectExpression<TExpression>,
        IQuerySelectIntoExpression<TExpression, TIdentifierExpression>
        where TExpression : IExpression
        where TIdentifierExpression : IIdentifierExpression
    {
        public abstract TIdentifierExpression IntoExpression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQuerySelectIntoExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQuerySelectIntoExpressionChildren(this, visitor);
        }
    }
}
