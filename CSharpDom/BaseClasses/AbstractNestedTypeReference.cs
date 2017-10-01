using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNestedTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        INestedTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract TTypeReference NestedType { get; }

        public abstract TTypeReference Type { get; }

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
