using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class CatchStatementFactory : AbstractStatementFactory<ICatchStatement, CatchStatement>
    {
        public CatchStatementFactory(ICatchStatement statement)
            : base(statement)
        {
        }

        public override void VisitCatchStatement<TTypeReference, TStatement>(ICatchStatement<TTypeReference, TStatement> catchStatement)
        {
            Value = new CatchStatement()
            {
                Statements = catchStatement.Statements.ToStatementListUsingFactory(),
                Type = new TypeReferenceFactory(catchStatement.Type).Value,
                VariableName = catchStatement.VariableName
            };
        }
    }
}
