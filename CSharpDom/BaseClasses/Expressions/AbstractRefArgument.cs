using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses.Expressions
{
    public abstract class AbstractRefArgument<TExpression> : AbstractArgument<TExpression>, IRefArgument<TExpression>
        where TExpression : IExpression
    {
        public override void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitRefArgument(this);
        }

        public override void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitRefArgumentChildren(this, visitor);
        }
    }
}
