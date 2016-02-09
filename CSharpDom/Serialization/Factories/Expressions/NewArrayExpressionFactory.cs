using System.Linq;
using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class NewArrayExpressionFactory : AbstractExpressionFactory<INewArrayExpression, NewArrayExpression>
    {
        public NewArrayExpressionFactory(INewArrayExpression expression)
            : base(expression)
        {
        }

        public override void VisitNewArrayExpression<TTypeReference, TExpression>(INewArrayExpression<TTypeReference, TExpression> newArrayExpression)
        {
            Value = new NewArrayExpression()
            {
                Dimensions = newArrayExpression.Dimensions.ToList(),
                ElementType = new TypeReferenceFactory(newArrayExpression.ElementType).Value,
                InitialSizeExpressions = newArrayExpression.InitialSizeExpressions.ToExpressionListUsingFactory()
            };
        }
    }
}
