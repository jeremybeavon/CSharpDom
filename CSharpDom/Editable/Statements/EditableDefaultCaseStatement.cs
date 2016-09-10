using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableDefaultCaseStatement<TStatement> : IDefaultCaseStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IDefaultCaseStatement<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitDefaultCaseStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitDefaultCaseStatementChildren(this, visitor);
        }
    }
}
