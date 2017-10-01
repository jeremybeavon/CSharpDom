using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryLetExpression<TExpression> :
        AbstractExpression,
        IQueryLetExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression Expression { get; }

        public abstract string Identifier { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryLetExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryLetExpressionChildren(this, visitor);
        }
    }
}
