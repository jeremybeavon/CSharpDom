using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryFromExpression<TExpression, TQueryExpression> :
        IQueryFromExpression<TExpression, TQueryExpression>
        where TExpression : IExpression
        where TQueryExpression : IQueryExpression
    {
        public abstract TExpression Expression { get; }

        public abstract string Identifier { get; }

        public abstract IReadOnlyList<TQueryExpression> QueryExpressions { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryFromExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryFromExpressionChildren(this, visitor);
        }
    }
}
