using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableBlockStatement<TStatement> : IBlockStatement<TStatement>
        where TStatement : IStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IBlockStatement<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBlockStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitBlockStatementChildren(this, visitor);
        }
    }
}
