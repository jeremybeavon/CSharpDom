using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class ClassNestedClassCollection : AbstractClassNestedClassCollection
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedClassCollection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithReflection> AbstractClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithReflection> SealedClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithReflection> StaticClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
