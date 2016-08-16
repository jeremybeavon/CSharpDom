using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedStructCollectionWithCodeAnalysis :
        AbstractStaticClassNestedStructCollection<StaticClassNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassNestedStructCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return new PartialStructNotSupported[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedStructWithCodeAnalysis> Structs
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStructs; }
        }
    }
}
