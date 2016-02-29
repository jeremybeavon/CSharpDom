using System;
using CSharpDom.BaseClasses;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class BuiltInTypeReferenceWithMonoCecil : AbstractBuiltInTypeReference, ITypeReferenceWithMonoCecil
    {
        private readonly BuiltInType type;

        internal BuiltInTypeReferenceWithMonoCecil(BuiltInType type, TypeReference typeReference)
        {
            this.type = type;
            TypeReference = typeReference;
        }

        public override BuiltInType Type
        {
            get { return type; }
        }

        public TypeReference TypeReference { get; private set; }
    }
}
