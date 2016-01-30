using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.Serialization.Statements
{
    public sealed class FinallyStatement : IFinallyStatement<Statement>
    {
        public FinallyStatement()
        {
            Statements = new List<Statement>();
        }

        public List<Statement> Statements { get; set; }

        IReadOnlyList<Statement> IFinallyStatement<Statement>.Statements
        {
            get { return Statements; }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitFinallyStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitFinallyStatementChildren(this, visitor);
        }
    }
}
