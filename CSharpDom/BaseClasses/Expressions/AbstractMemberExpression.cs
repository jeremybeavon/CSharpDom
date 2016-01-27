using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractMemberExpression<TExpression> : IMemberExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract string MemberName { get; }

        public abstract TExpression ObjectExpression { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitMemberExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitMemberExpressionChildren(this, visitor);
        }
    }
}
