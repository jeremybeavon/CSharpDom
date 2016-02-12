using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedClassCollectionWithReflection :
        AbstractClassNestedClassCollection<
            ClassNestedClassWithReflection,
            IClassNestedAbstractClass,
            IClassNestedSealedClass,
            IClassNestedStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassNestedClassCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
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
            get { return typeWithReflection.Classes.NestedTypes.NestedClasses; }
        }
    }
}
