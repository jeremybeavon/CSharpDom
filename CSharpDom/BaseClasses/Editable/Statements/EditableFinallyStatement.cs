using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableFinallyStatement<TStatement>  : AbstractStatement, IFinallyStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IFinallyStatement<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitFinallyStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitFinallyStatementChildren(this, visitor);
        }
    }
}
