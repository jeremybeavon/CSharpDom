using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class NewExpressionFactory : AbstractExpressionFactory<INewExpression, NewExpression>
    {
        public NewExpressionFactory(INewExpression expression)
            : base(expression)
        {
        }

        public override void VisitNewExpression<TTypeReference, TArgument>(
            INewExpression<TTypeReference, TArgument> newExpression)
        {
            Value = new NewExpression()
            {
                Parameters = newExpression.Parameters.ToList(argument => new ArgumentFactory(argument).Value),
                Type = new TypeReferenceFactory(newExpression.Type).Value
            };
        }
    }
}
