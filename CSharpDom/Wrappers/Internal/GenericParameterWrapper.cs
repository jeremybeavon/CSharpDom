using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class GenericParameterWrapper : AbstractWrapper<IGenericParameter>, IGenericParameterWrapper
    {
        private Func<ITypeReferenceWrapper> type;

        public GenericParameterWrapper(IGenericParameter genericParameter)
            : base(genericParameter)
        {
        }

        public ITypeReferenceWrapper Type
        {
            get { return type(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameter(this, visitor);
        }

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            type = () => TypeReferenceWrapper.Create(genericParameter.Type);
        }
    }
}
