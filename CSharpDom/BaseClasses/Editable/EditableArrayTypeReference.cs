using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableArrayTypeReference<TTypeReference> :
        EditableTypeReference,
        IEditableArrayTypeReference<TTypeReference>
        where TTypeReference : IEditableTypeReference
    {
        public abstract int Dimensions { get; set; }

        public abstract TTypeReference ElementType { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public override void Accept(IEditableVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitArrayTypeReferenceChildren(this, visitor);
        }

        public override void AcceptChildren(IEditableVisitor visitor)
        {
            throw new System.NotImplementedException();
        }
    }
}
