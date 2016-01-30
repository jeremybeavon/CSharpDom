using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Factories.Expressions;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class ForeachStatementFactory : AbstractStatementFactory<IForeachStatement, ForeachStatement>
    {
        public ForeachStatementFactory(IForeachStatement statement)
            : base(statement)
        {
        }

        public override void VisitForeachStatement<TTypeReference, TExpression, TStatement>(
            IForeachStatement<TTypeReference, TExpression, TStatement> foreachStatement)
        {
            Value = new ForeachStatement()
            {
                Iterator = new ExpressionFactory(foreachStatement.Iterator).Value,
                Statement = new StatementFactory(foreachStatement.Statement).Value,
                Type = new TypeReferenceFactory(foreachStatement.Type).Value,
                VariableName = foreachStatement.VariableName
            };
        }
    }
}
