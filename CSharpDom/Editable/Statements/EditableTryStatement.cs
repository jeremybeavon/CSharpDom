using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableTryStatement<TStatement, TCatchStatement, TFinallyStatement> :
        AbstractStatement,
        ITryStatement<TStatement, TCatchStatement, TFinallyStatement>
        where TStatement : IStatement
        where TCatchStatement : ICatchStatement
        where TFinallyStatement : IFinallyStatement
    {
        public abstract ICollection<TCatchStatement> CatchStatements { get; set; }

        public abstract TFinallyStatement FinallyStatement { get; set; }

        public abstract IList<TStatement> TryStatements { get; set; }

        IReadOnlyCollection<TCatchStatement> ITryStatement<TStatement, TCatchStatement, TFinallyStatement>.CatchStatements
        {
            get { return new ReadOnlyCollectionWrapper<TCatchStatement>(CatchStatements); }
        }

        IReadOnlyList<TStatement> ITryStatement<TStatement, TCatchStatement, TFinallyStatement>.TryStatements
        {
            get { return new ReadOnlyCollection<TStatement>(TryStatements); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitTryStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitTryStatementChildren(this, visitor);
        }
    }
}
