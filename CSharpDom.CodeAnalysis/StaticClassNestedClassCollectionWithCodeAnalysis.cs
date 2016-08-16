using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedClassCollectionWithCodeAnalysis :
        AbstractStaticClassNestedClassCollection<
            StaticClassNestedClassWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticClassNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StaticClassNestedClassCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<StaticClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StaticClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StaticClassNestedClassWithCodeAnalysis> Classes
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
