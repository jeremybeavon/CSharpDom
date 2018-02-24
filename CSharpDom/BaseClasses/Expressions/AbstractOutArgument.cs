using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractOutArgument<TExpression> : AbstractArgument<TExpression>, IOutArgument<TExpression>
        where TExpression : IExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitOutArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitOutArgumentChildren(this, visitor);
        }
    }
}
