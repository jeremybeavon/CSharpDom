using CSharpDom.Common.Statements;
using CSharpDom.Serialization.Statements;

namespace CSharpDom.Serialization.Factories.Statements
{
    public sealed class BlockStatementFactory : AbstractStatementFactory<IBlockStatement, BlockStatement>
    {
        public BlockStatementFactory(IBlockStatement statement)
            : base(statement)
        {
        }

        public override void VisitBlockStatement<TStatement>(IBlockStatement<TStatement> blockStatement)
        {
            Value = new BlockStatement()
            {
                Statements = blockStatement.Statements.ToStatementListUsingFactory()
            };
        }
    }
}
