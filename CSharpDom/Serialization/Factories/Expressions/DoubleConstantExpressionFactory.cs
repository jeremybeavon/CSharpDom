using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class DoubleConstantExpressionFactory : AbstractExpressionFactory<IDoubleConstantExpression, DoubleConstantExpression>
    {
        public DoubleConstantExpressionFactory(IDoubleConstantExpression expression)
            : base(expression)
        {
        }

        public override void VisitDoubleConstantExpression(IDoubleConstantExpression doubleConstantExpression)
        {
            Value = new DoubleConstantExpression()
            {
                Constant = doubleConstantExpression.Constant
            };
        }
    }
}
