using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ForInitializerStatementFactory : AbstractStatementFactory<IForInitializerStatement, ForInitializerStatement>
    {
        public ForInitializerStatementFactory(IForInitializerStatement statement)
            : base(statement)
        {
        }

        public override void VisitEmptyStatement(IEmptyStatement emptyStatement)
        {
            Value = new ForInitializerStatement()
            {
                EmptyStatement = new EmptyStatementFactory(emptyStatement).Value
            };
        }

        public override void VisitExpressionStatement<TExpression>(IExpressionStatement<TExpression> expressionStatement)
        {
            Value = new ForInitializerStatement()
            {
                ExpressionStatement = new ExpressionStatementFactory(expressionStatement).Value
            };
        }

        public override void VisitVariableDeclarationStatement<TTypeReference, TExpression>(
            IVariableDeclarationStatement<TTypeReference, TExpression> variableDeclarationStatement)
        {
            Value = new ForInitializerStatement()
            {
                VariableDeclarationStatement = new VariableDeclarationStatementFactory(variableDeclarationStatement).Value
            };
        }
    }
}
