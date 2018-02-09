using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableDelegateReference<TTypeReference> :
        EditableTypeReference,
        IEditableDelegateReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        public abstract IList<TTypeReference> GenericParameters { get; set; }

        public abstract string Name { get; set; }

        IReadOnlyList<TTypeReference> IHasGenericParameters<TTypeReference>.GenericParameters
        {
            get { return new ReadOnlyCollection<TTypeReference>(GenericParameters); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitDelegateReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateReferenceChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
