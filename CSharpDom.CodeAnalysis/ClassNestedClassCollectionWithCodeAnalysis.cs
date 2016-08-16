using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedClassCollectionWithCodeAnalysis :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithCodeAnalysis,
            ClassNestedAbstractClassWithCodeAnalysis,
            ClassNestedSealedClassWithCodeAnalysis,
            ClassNestedStaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly AbstractClassNestedClassCollection classCollection;

        internal ClassNestedClassCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            classCollection = new ClassNestedClassCollection(typeWithCodeAnalysis);
        }

        internal ClassNestedClassCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            classCollection = new SealedClassNestedClassCollection(typeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return classCollection.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return classCollection.PartialClasses; }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return classCollection.SealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return classCollection.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classCollection; }
        }
    }
}
