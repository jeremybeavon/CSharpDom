using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableMethodBody<TStatement> :
        EditableVisitableObject,
        IEditableMethodBody<TStatement>
    {
        public abstract IList<TStatement> Statements { get; set; }

        IReadOnlyList<TStatement> IMethodBody<TStatement>.Statements
        {
            get { return new ReadOnlyCollection<TStatement>(Statements); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitMethodBody(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
        }
    }
}
