using CSharpDom.BaseClasses.Statements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyBlockStatement : AbstractBlockStatement<ReadOnlyStatement>
    {
        private readonly IReadOnlyList<ReadOnlyStatement> statements;

        public ReadOnlyBlockStatement(BlockStatement statement)
        {
            statements = ReadOnlyStatement.Create(statement.Statements);
        }

        public override IReadOnlyList<ReadOnlyStatement> Statements
        {
            get { return statements; }
        }
    }
}
