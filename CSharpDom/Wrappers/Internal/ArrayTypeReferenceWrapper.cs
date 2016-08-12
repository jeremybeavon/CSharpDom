using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ArrayTypeReferenceWrapper : AbstractWrapper<IArrayTypeReference>, IArrayTypeReferenceWrapper
    {
        private Func<int> dimensions;
        private Func<ITypeReferenceWrapper> elementType;

        public ArrayTypeReferenceWrapper(IArrayTypeReference arrayTypeReference)
            : base(arrayTypeReference)
        {
        }

        public int Dimensions
        {
            get { return dimensions(); }
        }

        public ITypeReferenceWrapper ElementType
        {
            get { return elementType(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitArrayTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitArrayTypeReferenceChildren(this, visitor);
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            dimensions = () => arrayTypeReference.Dimensions;
            elementType = () => TypeReferenceWrapper.Create(arrayTypeReference.ElementType);
        }
    }
}
