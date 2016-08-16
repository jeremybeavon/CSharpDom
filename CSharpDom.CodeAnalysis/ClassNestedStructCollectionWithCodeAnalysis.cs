using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedStructCollectionWithCodeAnalysis :
        AbstractClassNestedStructCollection<ClassNestedStructWithCodeAnalysis, PartialStructNotSupported>
    {
        private readonly AbstractClassNestedStructCollection structCollection;

        internal ClassNestedStructCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            structCollection = new ClassNestedStructCollection(typeWithCodeAnalysis);
        }

        internal ClassNestedStructCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            structCollection = new SealedClassNestedStructCollection(typeWithCodeAnalysis);
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return structCollection.PartialStructs; }
        }

        protected override IReadOnlyCollection<ClassNestedStructWithCodeAnalysis> Structs
        {
            get { return structCollection; }
        }
    }
}
