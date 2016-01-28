using System;
using CSharpDom.Common;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyTypeReference : ITypeReference
    {
        private readonly ITypeReference typeReference;

        public ReadOnlyTypeReference(TypeReference typeReference)
        {
            this.typeReference = this;
        }

        public void Accept(IGenericVisitor visitor)
        {
            typeReference.Accept(visitor);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            typeReference.AcceptChildren(visitor);
        }
    }
}
