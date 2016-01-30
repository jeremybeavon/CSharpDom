using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class VariableDeclarationStatementFactory : AbstractStatementFactory<IVariableDeclarationStatement, VariableDeclarationStatement>
    {
        public VariableDeclarationStatementFactory(IVariableDeclarationStatement statement)
            : base(statement)
        {
        }

        public override void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
        {
            Value = new VariableDeclarationStatement()
            {
                Expressions = variableDeclarationStatement.Expressions.ToExpressionListUsingFactory(),
                Type = new TypeReferenceFactory(variableDeclarationStatement.Type).Value
            };
        }
    }
}
