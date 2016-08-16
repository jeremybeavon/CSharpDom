using System;
using CSharpDom.BaseClasses;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class BuiltInTypeReferenceWithCodeAnalysis : AbstractBuiltInTypeReference, ITypeReferenceWithCodeAnalysis
    {
        private readonly BuiltInType type;

        internal BuiltInTypeReferenceWithCodeAnalysis(BuiltInType type, TypeReference typeReference)
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
