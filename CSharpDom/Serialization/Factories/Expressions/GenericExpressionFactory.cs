using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class GenericExpressionFactory : AbstractExpressionFactory<IGenericExpression, GenericExpression>
    {
        public GenericExpressionFactory(IGenericExpression expression)
            : base(expression)
        {
        }

        public override void Visit(IVisitable<IGenericExpressionVisitor> node)
        {
            if (node is IExpression expression)
            {
                Value = new GenericExpression()
                {
                    Expression = new ExpressionFactory(expression).Value
                };
            }
            else
            {
                base.Visit(node);
            }
        }

        public override void VisitGenericMemberExpression<TExpression, TTypeReference>(
            IGenericMemberExpression<TExpression, TTypeReference> memberExpression)
        {
            Value = new GenericExpression()
            {
                GenericMemberExpression = new GenericMemberExpressionFactory(memberExpression).Value
            };
        }
    }
}
