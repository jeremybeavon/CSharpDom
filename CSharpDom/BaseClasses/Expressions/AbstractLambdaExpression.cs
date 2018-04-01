using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractLambdaExpression<TExpression> :
        AbstractExpression,
        ILambdaExpression<TExpression>
        where TExpression : IExpression
    {
        public abstract string ParameterName { get; }

        public abstract TExpression Expression { get; }

        public abstract bool IsAsync { get; }

        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitLambdaExpression(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitLambdaExpressionChildren(this, visitor);
        }
    }
}
