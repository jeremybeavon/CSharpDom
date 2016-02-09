using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class RawExpressionFactory : AbstractExpressionFactory<IRawExpression, RawExpression>
    {
        public RawExpressionFactory(IRawExpression expression)
            : base(expression)
        {
        }
    }
}
