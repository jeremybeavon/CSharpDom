using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassNestedClassCollectionWithMonoCecil :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithMonoCecil,
            ClassNestedAbstractClassWithMonoCecil,
            ClassNestedSealedClassWithMonoCecil,
            ClassNestedStaticClassWithMonoCecil,
            PartialClassCollectionNotSupported>
    {
        private readonly AbstractClassNestedClassCollection classCollection;

        internal ClassNestedClassCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            classCollection = new ClassNestedClassCollection(typeWithMonoCecil);
        }

        internal ClassNestedClassCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            classCollection = new SealedClassNestedClassCollection(typeWithMonoCecil);
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithMonoCecil> AbstractClasses
        {
            get { return classCollection.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return classCollection.PartialClasses; }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithMonoCecil> SealedClasses
        {
            get { return classCollection.SealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithMonoCecil> StaticClasses
        {
            get { return classCollection.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithMonoCecil> Classes
        {
            get { return classCollection; }
        }
    }
}
