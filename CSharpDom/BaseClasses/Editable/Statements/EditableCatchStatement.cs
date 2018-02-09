using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Statements;
using CSharpDom.Common.Statements;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable.Statements
{
    public abstract class EditableCatchStatement<TTypeReference, TStatement> :
        EditableStatement,
        IEditableCatchStatement<TTypeReference, TStatement>
        where TTypeReference : IEditableTypeReference
        where TStatement : IEditableStatement
    {
        public abstract IList<TStatement> Statements { get; set; }

        public abstract TTypeReference Type { get; set; }

        public abstract string VariableName { get; set; }

        IReadOnlyList<TStatement> ICatchStatement<TTypeReference, TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public override void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitCatchStatement(this);
        }

        public override void Accept(IEditableStatementVisitor visitor)
        {
            visitor.VisitCatchStatement(this);
        }

        public override void AcceptChildren(IGenericStatementVisitor visitor)
        {
            GenericStatementVisitor.VisitCatchStatementChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableStatementVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
