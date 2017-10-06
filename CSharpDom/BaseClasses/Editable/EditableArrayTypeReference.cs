using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableArrayTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IArrayTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract int Dimensions { get; set; }

        public abstract TTypeReference ElementType { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitArrayTypeReferenceChildren(this, visitor);
        }
    }
}
