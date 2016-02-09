using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class NullExpressionFactory : AbstractExpressionFactory<INullExpression, NullExpression>
    {
        public NullExpressionFactory(INullExpression expression)
            : base(expression)
        {
        }

        public override void VisitNullExpression(INullExpression nullExpression)
        {
            Value = new NullExpression();
        }
    }
}
