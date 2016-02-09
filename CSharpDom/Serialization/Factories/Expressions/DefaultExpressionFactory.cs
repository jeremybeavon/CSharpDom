using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class DefaultExpressionFactory : AbstractExpressionFactory<IDefaultExpression, DefaultExpression>
    {
        public DefaultExpressionFactory(IDefaultExpression expression)
            : base(expression)
        {
        }

        public override void VisitDefaultExpression<TTypeReference>(IDefaultExpression<TTypeReference> defaultExpression)
        {
            Value = new DefaultExpression()
            {
                Type = new TypeReferenceFactory(defaultExpression.Type).Value
            };
        }
    }
}
