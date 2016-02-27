using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassCollectionWithMonoCecil :
        AbstractClassCollection<
            ClassWithMonoCecil,
            AbstractClassWithMonoCecil,
            SealedClassWithMonoCecil,
            StaticClassWithMonoCecil,
            PartialClassCollectionNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal ClassCollectionWithMonoCecil(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<AbstractClassWithMonoCecil> AbstractClasses
        {
            get { return typeContainer.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<SealedClassWithMonoCecil> SealedClasses
        {
            get { return typeContainer.SealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassWithMonoCecil> StaticClasses
        {
            get { return typeContainer.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassWithMonoCecil> Classes
        {
            get { return typeContainer.Classes; }
        }
    }
}
