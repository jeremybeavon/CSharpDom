using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Editable.Statements;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class FinallyStatementWithCodeAnalysis<TStatement> : IFinallyStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IFinallyStatement<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
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
