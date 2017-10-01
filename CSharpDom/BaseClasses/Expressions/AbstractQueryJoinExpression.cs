using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractQueryJoinExpression<TExpression> :
        AbstractExpression,
        IQueryJoinExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract TExpression EqualsExpression { get; }

        public abstract TExpression InExpression { get; }

        public abstract string IntoVariable { get; }

        public abstract string JoinVariable { get; }

        public abstract TExpression OnExpression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitQueryJoinExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitQueryJoinExpressionChildren(this, visitor);
        }
    }
}
