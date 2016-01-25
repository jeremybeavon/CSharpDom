using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractArrayTypeReference<TTypeReference> : IArrayTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract int Dimensions { get; }

        public abstract TTypeReference ElementType { get; }

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
