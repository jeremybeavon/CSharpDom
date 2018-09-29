using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class GenericMemberExpressionFactory : AbstractExpressionFactory<IGenericMemberExpression, GenericMemberExpression>
    {
        public GenericMemberExpressionFactory(IGenericMemberExpression expression)
            : base(expression)
        {
        }

        public override void VisitGenericMemberExpression<TExpression, TTypeReference>(
            IGenericMemberExpression<TExpression, TTypeReference> memberExpression)
        {
            Value = new GenericMemberExpression()
            {
                GenericParameters = memberExpression.GenericParameters.ToGenericParameterListUsingFactory(),
                MemberName = memberExpression.MemberName,
                ObjectExpression = new ExpressionFactory(memberExpression.ObjectExpression).Value
            };
        }
    }
}
