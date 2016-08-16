using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassCollectionWithCodeAnalysis :
        AbstractClassCollection<
            ClassWithCodeAnalysis,
            AbstractClassWithCodeAnalysis,
            SealedClassWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            PartialClassCollectionNotSupported>
    {
        private readonly TypeContainer typeContainer;

        internal ClassCollectionWithCodeAnalysis(TypeContainer typeContainer)
        {
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<AbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return typeContainer.AbstractClasses; }
        }

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get { return new PartialClassCollectionNotSupported(); }
        }

        public override IReadOnlyCollection<SealedClassWithCodeAnalysis> SealedClasses
        {
            get { return typeContainer.SealedClasses; }
        }

        public override IReadOnlyCollection<StaticClassWithCodeAnalysis> StaticClasses
        {
            get { return typeContainer.StaticClasses; }
        }

        protected override IReadOnlyCollection<ClassWithCodeAnalysis> Classes
        {
            get { return typeContainer.Classes; }
        }
    }
}
