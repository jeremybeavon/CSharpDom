using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryFromExpression<TExpression> :
        AbstractExpression,
        IQueryFromExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract string Identifier { get; }
        
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryFromExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryFromExpressionChildren(this, visitor);
        }
    }
}
