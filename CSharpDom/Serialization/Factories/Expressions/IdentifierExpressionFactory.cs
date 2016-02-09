using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class IdentifierExpressionFactory : AbstractExpressionFactory<IIdentifierExpression, IdentifierExpression>
    {
        public IdentifierExpressionFactory(IIdentifierExpression expression)
            : base(expression)
        {
        }

        public override void VisitIdentifierExpression(IIdentifierExpression identifierExpression)
        {
            Value = new IdentifierExpression()
            {
                Name = identifierExpression.Name
            };
        }
    }
}
