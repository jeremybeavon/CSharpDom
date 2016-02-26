using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedClassCollectionWithReflection :
        AbstractStaticClassNestedClassCollection<
            StaticClassNestedClassWithReflection,
            StaticClassNestedAbstractClassWithReflection,
            StaticClassNestedSealedClassWithReflection,
            StaticClassNestedStaticClassWithReflection,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassNestedClassCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<StaticClassNestedAbstractClassWithReflection> AbstractClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedAbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<StaticClassNestedSealedClassWithReflection> SealedClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedSealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassNestedStaticClassWithReflection> StaticClasses
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedStaticClasses; }
        }

        protected override IReadOnlyCollection<StaticClassNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
