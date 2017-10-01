using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractMemberExpression<TExpression> : AbstractExpression, IMemberExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract string MemberName { get; }

        public abstract TExpression ObjectExpression { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMemberExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMemberExpressionChildren(this, visitor);
        }
    }
}
