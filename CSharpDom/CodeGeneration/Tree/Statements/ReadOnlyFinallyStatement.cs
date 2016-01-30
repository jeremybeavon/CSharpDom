using CSharpDom.BaseClasses.Statements;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyFinallyStatement : AbstractFinallyStatement<ReadOnlyStatement>
    {
        private readonly IReadOnlyList<ReadOnlyStatement> statements;

        public ReadOnlyFinallyStatement(FinallyStatement finallyStatement)
        {
            statements = ReadOnlyStatement.Create(finallyStatement.Statements);
        }

        public override IReadOnlyList<ReadOnlyStatement> Statements
        {
            get { return statements; }
        }
    }
}
