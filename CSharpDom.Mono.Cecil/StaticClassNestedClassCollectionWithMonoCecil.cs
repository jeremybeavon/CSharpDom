using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassNestedClassCollectionWithMonoCecil :
        AbstractStaticClassNestedClassCollection<
            StaticClassNestedClassWithMonoCecil,
            StaticClassNestedAbstractClassWithMonoCecil,
            StaticClassNestedSealedClassWithMonoCecil,
            StaticClassNestedStaticClassWithMonoCecil,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithMonoCecil typeWithMonoCecil;

        internal StaticClassNestedClassCollectionWithMonoCecil(StaticTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<StaticClassNestedAbstractClassWithMonoCecil> AbstractClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StaticClassNestedSealedClassWithMonoCecil> SealedClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassNestedStaticClassWithMonoCecil> StaticClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StaticClassNestedClassWithMonoCecil> Classes
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
