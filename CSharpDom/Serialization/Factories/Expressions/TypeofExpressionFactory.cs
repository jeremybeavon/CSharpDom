using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using CSharpDom.Serialization.Factories.Statements;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class TypeofExpressionFactory : AbstractExpressionFactory<ITypeofExpression, TypeofExpression>
    {
        public TypeofExpressionFactory(ITypeofExpression expression)
            : base(expression)
        {
        }

        public override void VisitTypeofExpression<TTypeReference>(ITypeofExpression<TTypeReference> typeofExpression)
        {
            Value = new TypeofExpression()
            {
                Type = new TypeReferenceFactory(typeofExpression.Type).Value
            };
        }
    }
}
