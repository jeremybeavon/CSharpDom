using CSharpDom.Common.Expressions;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression> :
        IObjectInitializerExpression<TCreateObjectExpression, TBinaryOperatorExpression>
        where TCreateObjectExpression : ICreateObjectExpression
        where TBinaryOperatorExpression : IBinaryOperatorExpression
    {
        public abstract TCreateObjectExpression CreateObjectExpression { get; }

        public abstract IReadOnlyCollection<TBinaryOperatorExpression> Members { get; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitObjectInitializerExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitObjectInitializerExpressionChildren(this, visitor);
        }
    }
}
