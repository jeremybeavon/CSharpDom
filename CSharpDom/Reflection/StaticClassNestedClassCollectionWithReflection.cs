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
            IStaticClassNestedAbstractClass,
            IStaticClassNestedSealedClass,
            IStaticClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly StaticTypeWithReflection typeWithReflection;

        internal StaticClassNestedClassCollectionWithReflection(StaticTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<IStaticClassNestedAbstractClass> AbstractClasses
        {
            get { return new IStaticClassNestedAbstractClass[0]; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<IStaticClassNestedSealedClass> SealedClasses
        {
            get { return new IStaticClassNestedSealedClass[0]; }
        }

        public override IReadOnlyCollection<IStaticClassNestedStaticClass> StaticClasses
        {
            get { return new IStaticClassNestedStaticClass[0]; }
        }

        protected override IReadOnlyCollection<StaticClassNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.NestedTypeCollection.NestedTypes.NestedClasses; }
        }
    }
}
