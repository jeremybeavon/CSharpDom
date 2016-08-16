using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableArrayTypeReference<TTypeReference> : IArrayTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public virtual int Dimensions { get; set; }

        public virtual TTypeReference ElementType { get; set; }

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
