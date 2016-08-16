using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class SealedClassNestedStructCollection : AbstractClassNestedStructCollection
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal SealedClassNestedStructCollection(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        protected override IReadOnlyCollection<ClassNestedStructWithCodeAnalysis> Structs
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
