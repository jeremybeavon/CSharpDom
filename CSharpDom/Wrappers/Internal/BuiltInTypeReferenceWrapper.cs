using System;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class BuiltInTypeReferenceWrapper : AbstractWrapper<IBuiltInTypeReference>, IBuiltInTypeReferenceWrapper
    {
        private Func<BuiltInType> type;

        public BuiltInTypeReferenceWrapper(IBuiltInTypeReference typeReference)
            : base(typeReference)
        {
        }

        public BuiltInType Type
        {
            get { return type(); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitBuiltInTypeReference(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
        }

        public override void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference)
        {
            type = () => builtInTypeReference.Type;
        }
    }
}
