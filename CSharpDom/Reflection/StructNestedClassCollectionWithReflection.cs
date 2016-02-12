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
            IStructNestedAbstractClass,
            IStructNestedSealedClass,
            IStructNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly StructTypeWithReflection typeWithReflection;

        internal StructNestedClassCollectionWithReflection(StructTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<IStructNestedAbstractClass> AbstractClasses
        {
            get { return new IStructNestedAbstractClass[0]; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<IStructNestedSealedClass> SealedClasses
        {
            get { return new IStructNestedSealedClass[0]; }
        }

        public override IReadOnlyCollection<IStructNestedStaticClass> StaticClasses
        {
            get { return new IStructNestedStaticClass[0]; }
        }

        protected override IReadOnlyCollection<StructNestedClassWithReflection> Classes
        {
            get { return typeWithReflection.Classes.NestedTypes.NestedClasses; }
        }
    }
}
