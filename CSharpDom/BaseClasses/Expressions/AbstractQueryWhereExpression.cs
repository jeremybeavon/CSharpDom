using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryWhereExpression<TExpression> :
        AbstractExpression,
        IQueryWhereExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryWhereExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryWhereExpressionChildren(this, visitor);
        }
    }
}
