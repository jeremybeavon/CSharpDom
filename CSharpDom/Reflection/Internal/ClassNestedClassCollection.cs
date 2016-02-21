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

        public override IReadOnlyCollection<IClassNestedAbstractClass> AbstractClasses
        {
            get { return new IClassNestedAbstractClass[0]; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<IClassNestedSealedClass> SealedClasses
        {
            get { return new IClassNestedSealedClass[0]; }
        }

        public override IReadOnlyCollection<IClassNestedStaticClass> StaticClasses
        {
            get { return new IClassNestedStaticClass[0]; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
