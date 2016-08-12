using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class NestedTypeReferenceWrapper : AbstractWrapper<INestedTypeReference>, INestedTypeReferenceWrapper
    {
        private Func<ITypeReferenceWrapper> nestedType;
        private Func<ITypeReferenceWrapper> type;

        public NestedTypeReferenceWrapper(INestedTypeReference typeReference)
            : base(typeReference)
        {
        }

        public ITypeReferenceWrapper NestedType
        {
            get { return nestedType(); }
        }

        public ITypeReferenceWrapper Type
        {
            get { return type(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedTypeReferenceChildren(this, visitor);
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            nestedType = () => TypeReferenceWrapper.Create(nestedTypeReference.NestedType);
            type = () => TypeReferenceWrapper.Create(nestedTypeReference.Type);
        }
    }
}
