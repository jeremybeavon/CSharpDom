using System;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableNestedTypeReference<TTypeReference> : INestedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public virtual TTypeReference NestedType { get; set; }

        public virtual TTypeReference Type { get; set; }

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
