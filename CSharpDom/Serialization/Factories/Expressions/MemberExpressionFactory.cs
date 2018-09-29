using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class MemberExpressionFactory : AbstractExpressionFactory<IMemberExpression, MemberExpression>
    {
        public MemberExpressionFactory(IMemberExpression expression)
            : base(expression)
        {
        }

        public override void VisitMemberExpression<TExpression>(IMemberExpression<TExpression> memberExpression)
        {
            Value = new MemberExpression()
            {
                MemberName = memberExpression.MemberName,
                ObjectExpression = new ExpressionFactory(memberExpression.ObjectExpression).Value
            };
        }
    }
}
