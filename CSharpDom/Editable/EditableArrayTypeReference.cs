using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableArrayTypeReference<TTypeReference> : IArrayTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract int Dimensions { get; set; }

        public abstract TTypeReference ElementType { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitArrayTypeReferenceChildren(this, visitor);
        }
    }
}
