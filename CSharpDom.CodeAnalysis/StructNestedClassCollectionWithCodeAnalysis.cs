using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedClassCollectionWithCodeAnalysis :
        AbstractStructNestedClassCollection<
            StructNestedClassWithCodeAnalysis,
            StructNestedAbstractClassWithCodeAnalysis,
            StructNestedSealedClassWithCodeAnalysis,
            StructNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructNestedClassCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<StructNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StructNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StructNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StructNestedClassWithCodeAnalysis> Classes
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
