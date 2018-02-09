using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStructReference<TTypeReference> :
        EditableTypeReference,
        IEditableStructReference<TTypeReference>
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
            visitor.VisitStructReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitStructReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructReferenceChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
