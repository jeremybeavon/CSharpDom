using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CSharpDom.Common.Statements;
using CSharpDom.Common;

namespace CSharpDom.Editable.Statements
{
    public abstract class EditableCatchStatement<TTypeReference, TStatement> :
        ICatchStatement<TTypeReference, TStatement>
        where TTypeReference : ITypeReference
        where TStatement : IStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        public abstract TTypeReference Type { get; set; }

        public abstract string VariableName { get; set; }

        IReadOnlyList<TStatement> ICatchStatement<TTypeReference, TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitCatchStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitCatchStatementChildren(this, visitor);
        }
    }
}
