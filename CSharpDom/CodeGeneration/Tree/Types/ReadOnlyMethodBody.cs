using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeGeneration.Tree.Statements;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyMethodBody : AbstractMethodBody<ReadOnlyStatement>
    {
        private readonly IReadOnlyList<ReadOnlyStatement> statements;

        public ReadOnlyMethodBody(IEnumerable<Statement> statements)
        {
            this.statements = ReadOnlyStatement.Create(statements);
        }

        public override IReadOnlyList<ReadOnlyStatement> Statements
        {
            get { return statements; }
        }
    }
}
