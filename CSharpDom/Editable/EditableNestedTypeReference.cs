using System;
using CSharpDom.Common;
using CSharpDom.BaseClasses;

namespace CSharpDom.Editable
{
    public abstract class EditableNestedTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        INestedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference NestedType { get; set; }

        public abstract TTypeReference Type { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedTypeReference(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedTypeReferenceChildren(this, visitor);
        }
    }
}
