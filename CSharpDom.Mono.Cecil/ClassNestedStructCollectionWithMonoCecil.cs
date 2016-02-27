using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassNestedStructCollectionWithMonoCecil :
        AbstractClassNestedStructCollection<ClassNestedStructWithMonoCecil, PartialStructNotSupported>
    {
        private readonly AbstractClassNestedStructCollection structCollection;

        internal ClassNestedStructCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            structCollection = new ClassNestedStructCollection(typeWithMonoCecil);
        }

        internal ClassNestedStructCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            structCollection = new SealedClassNestedStructCollection(typeWithMonoCecil);
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return structCollection.PartialStructs; }
        }

        protected override IReadOnlyCollection<ClassNestedStructWithMonoCecil> Structs
        {
            get { return structCollection; }
        }
    }
}
