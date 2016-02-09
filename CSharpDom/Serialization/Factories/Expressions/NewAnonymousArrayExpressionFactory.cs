using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class NewAnonymousArrayExpressionFactory : AbstractExpressionFactory<INewAnonymousArrayExpression, NewAnonymousArrayExpression>
    {
        public NewAnonymousArrayExpressionFactory(INewAnonymousArrayExpression expression)
            : base(expression)
        {
        }

        public override void VisitNewAnonymousArrayExpression(INewAnonymousArrayExpression newAnonymousArrayExpression)
        {
            Value = new NewAnonymousArrayExpression();
        }
    }
}
