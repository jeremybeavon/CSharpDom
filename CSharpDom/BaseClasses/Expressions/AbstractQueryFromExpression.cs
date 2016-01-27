using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryFromExpression<TIdentifierExpression, TExpression> :
        IQueryFromExpression<TIdentifierExpression, TExpression>
        where TIdentifierExpression : IIdentifierExpression
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract TIdentifierExpression Identifier { get; }

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
