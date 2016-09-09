using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableNestedTypeReference<TTypeReference> : INestedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference NestedType { get; set; }

        public abstract TTypeReference Type { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedTypeReferenceChildren(this, visitor);
        }
    }
}
