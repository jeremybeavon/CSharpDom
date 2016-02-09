using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ListInitializerExpressionFactory : AbstractExpressionFactory<IListInitializerExpression, ListInitializerExpression>
    {
        public ListInitializerExpressionFactory(IListInitializerExpression expression)
            : base(expression)
        {
        }

        public override void VisitListInitializerExpression<TCreateListExpression, TExpression>(
            IListInitializerExpression<TCreateListExpression, TExpression> listInitializerExpression)
        {
            base.VisitListInitializerExpression<TCreateListExpression, TExpression>(listInitializerExpression);
        }
    }
}
