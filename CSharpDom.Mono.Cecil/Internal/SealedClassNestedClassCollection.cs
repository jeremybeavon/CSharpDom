using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class SealedClassNestedClassCollection : AbstractClassNestedClassCollection
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassNestedClassCollection(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithMonoCecil> AbstractClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithMonoCecil> SealedClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithMonoCecil> StaticClasses
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithMonoCecil> Classes
        {
            get { return typeWithMonoCecil.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
