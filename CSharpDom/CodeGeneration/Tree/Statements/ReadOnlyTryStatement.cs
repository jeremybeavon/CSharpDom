using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses.Statements;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyTryStatement :
        AbstractTryStatement<ReadOnlyStatement, ReadOnlyCatchStatement, ReadOnlyFinallyStatement>
    {
        private readonly IReadOnlyList<ReadOnlyStatement> tryStatements;
        private readonly IReadOnlyCollection<ReadOnlyCatchStatement> catchStatements;
        private readonly ReadOnlyFinallyStatement finallyStatement;

        public ReadOnlyTryStatement(TryStatement tryStatement)
        {
            tryStatements = ReadOnlyStatement.Create(tryStatement.TryStatements);
            catchStatements = tryStatement.CatchStatements
                .ToArray(catchStatement => new ReadOnlyCatchStatement(catchStatement));
            if (tryStatement.FinallyStatement != null)
            {
                finallyStatement = new ReadOnlyFinallyStatement(tryStatement.FinallyStatement);
            }
        }

        public override IReadOnlyCollection<ReadOnlyCatchStatement> CatchStatements
        {
            get { return catchStatements; }
        }

        public override ReadOnlyFinallyStatement FinallyStatement
        {
            get { return finallyStatement; }
        }

        public override IReadOnlyList<ReadOnlyStatement> TryStatements
        {
            get { return tryStatements; }
        }
    }
}
