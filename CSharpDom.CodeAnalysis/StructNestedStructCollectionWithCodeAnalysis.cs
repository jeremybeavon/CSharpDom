using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedStructCollectionWithCodeAnalysis :
        AbstractStructNestedStructCollection<StructNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructNestedStructCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StructNestedStructWithCodeAnalysis> Structs
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
