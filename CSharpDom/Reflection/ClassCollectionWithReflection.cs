using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassCollectionWithReflection :
        AbstractClassCollection<
            ClassWithReflection,
            IAbstractClass,
            ISealedClass,
            IStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal ClassCollectionWithReflection(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<IAbstractClass> AbstractClasses
        {
            get { return new IAbstractClass[0]; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<ISealedClass> SealedClasses
        {
            get { return new ISealedClass[0]; }
        }

        public override IReadOnlyCollection<IStaticClass> StaticClasses
        {
            get { return new IStaticClass[0]; }
        }

        protected override IReadOnlyCollection<ClassWithReflection> Classes
        {
            get { return typeContainer.Classes; }
        }
    }
}
