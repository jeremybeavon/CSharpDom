using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructNestedClassCollectionWithMonoCecil :
        AbstractStructNestedClassCollection<
            StructNestedClassWithMonoCecil,
            StructNestedAbstractClassWithMonoCecil,
            StructNestedSealedClassWithMonoCecil,
            StructNestedStaticClassWithMonoCecil,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructNestedClassCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<StructNestedAbstractClassWithMonoCecil> AbstractClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StructNestedSealedClassWithMonoCecil> SealedClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StructNestedStaticClassWithMonoCecil> StaticClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StructNestedClassWithMonoCecil> Classes
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
