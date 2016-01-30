using CSharpDom.BaseClasses.Statements;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class BlockStatementWithLinqExpressions : AbstractBlockStatement<ILinqStatement>, ILinqStatement<BlockExpression>
    {
        private readonly IReadOnlyList<ILinqStatement> statements;

        public BlockStatementWithLinqExpressions(BlockExpression statement)
        {
            Statement = statement;
            statements = LinqStatementBuilder.BuildStatements(statement.Expressions);
        }

        public BlockExpression Statement { get; private set; }

        public override IReadOnlyList<ILinqStatement> Statements
        {
            get { return statements; }
        }

        Expression ILinqStatement.Statement
        {
            get { return Statement; }
        }
    }
}
