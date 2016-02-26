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
            AbstractClassWithReflection,
            SealedClassWithReflection,
            StaticClassWithReflection,
            PartialClassCollectionNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal ClassCollectionWithReflection(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<AbstractClassWithReflection> AbstractClasses
        {
            get { return typeContainer.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<SealedClassWithReflection> SealedClasses
        {
            get { return typeContainer.SealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassWithReflection> StaticClasses
        {
            get { return typeContainer.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassWithReflection> Classes
        {
            get { return typeContainer.Classes; }
        }
    }
}
