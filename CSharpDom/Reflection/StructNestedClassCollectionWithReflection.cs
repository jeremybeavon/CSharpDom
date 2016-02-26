using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StructNestedClassCollectionWithReflection :
        AbstractStructNestedClassCollection<
            StructNestedClassWithReflection,
            StructNestedAbstractClassWithReflection,
            StructNestedSealedClassWithReflection,
            StructNestedStaticClassWithReflection,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructNestedClassCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<StructNestedAbstractClassWithReflection> AbstractClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StructNestedSealedClassWithReflection> SealedClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StructNestedStaticClassWithReflection> StaticClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StructNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
