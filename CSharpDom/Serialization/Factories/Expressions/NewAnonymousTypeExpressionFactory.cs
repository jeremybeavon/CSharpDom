using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class NewAnonymousTypeExpressionFactory : AbstractExpressionFactory<INewAnonymousTypeExpression, NewAnonymousTypeExpression>
    {
        public NewAnonymousTypeExpressionFactory(INewAnonymousTypeExpression expression)
            : base(expression)
        {
        }

        public override void VisitNewAnonymousTypeExpression(INewAnonymousTypeExpression newAnonymousTypeExpression)
        {
            Value = new NewAnonymousTypeExpression();
        }
    }
}
