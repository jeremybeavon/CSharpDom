using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class TryStatement : ITryStatement<Statement, CatchStatement, FinallyStatement>
    {
        public TryStatement()
        {
            CatchStatements = new List<CatchStatement>();
            TryStatements = new List<Statement>();
        }

        public List<CatchStatement> CatchStatements { get; set; }

        public FinallyStatement FinallyStatement { get; set; }

        public List<Statement> TryStatements { get; set; }

        IReadOnlyCollection<CatchStatement> ITryStatement<Statement, CatchStatement, FinallyStatement>.CatchStatements
        {
            get { return CatchStatements; }
        }

        IReadOnlyList<Statement> ITryStatement<Statement, CatchStatement, FinallyStatement>.TryStatements
        {
            get { return TryStatements; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitTryStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitTryStatementChildren(this, visitor);
        }
    }
}
