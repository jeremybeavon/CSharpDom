using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ArrayIndexExpressionFactory : AbstractExpressionFactory<IArrayIndexExpression, ArrayIndexExpression>
    {
        public ArrayIndexExpressionFactory(IArrayIndexExpression expression)
            : base(expression)
        {
        }

        public override void VisitArrayIndexExpression<TExpression, TArgument>(
            IArrayIndexExpression<TExpression, TArgument> arrayIndexExpression)
        {
            Value = new ArrayIndexExpression()
            {
                Array = new ExpressionFactory(arrayIndexExpression.Array).Value,
                Indexes = arrayIndexExpression.Indexes.ToList(argument => new ArgumentFactory(argument).Value)
            };
        }
    }
}
