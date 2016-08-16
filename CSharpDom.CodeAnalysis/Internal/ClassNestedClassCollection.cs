using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class ClassNestedClassCollection : AbstractClassNestedClassCollection
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal ClassNestedClassCollection(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<ClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<ClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<ClassNestedClassWithCodeAnalysis> Classes
        {
            get { return typeWithCodeAnalysis.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
