using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.NotSupported.Partial;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedStructCollectionWithReflection :
        AbstractClassNestedStructCollection<ClassNestedStructWithReflection, PartialStructNotSupported>
    {
        private readonly AbstractClassNestedStructCollection structCollection;

        internal ClassNestedStructCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            structCollection = new ClassNestedStructCollection(typeWithReflection);
        }

        internal ClassNestedStructCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            structCollection = new SealedClassNestedStructCollection(typeWithReflection);
        }

        public override IReadOnlyCollection<PartialStructNotSupported> PartialStructs
        {
            get { return structCollection.PartialStructs; }
        }

        protected override IReadOnlyCollection<ClassNestedStructWithReflection> Structs
        {
            get { return structCollection; }
        }
    }
}
