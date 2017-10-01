using System;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractArrayTypeReference<TTypeReference> :
        AbstractGenericVisitableObject,
        IArrayTypeReference<TTypeReference>
        where TTypeReference : ITypeReference
    {
        public abstract int Dimensions { get; }

        public abstract TTypeReference ElementType { get; }

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
