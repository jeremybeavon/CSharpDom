using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class StringConstantExpressionFactory : AbstractExpressionFactory<IStringConstantExpression, StringConstantExpression>
    {
        public StringConstantExpressionFactory(IStringConstantExpression expression)
            : base(expression)
        {
        }

        public override void VisitStringConstantExpression(IStringConstantExpression stringConstantExpression)
        {
            Value = new StringConstantExpression()
            {
                Constant = stringConstantExpression.Constant,
                HasAtSymbol = stringConstantExpression.HasAtSymbol
            };
        }
    }
}
