using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassCollection :
        AbstractClassCollection<
            ReadOnlyClass,
            IAbstractClass,
            ISealedClass,
            IStaticClass,
            PartialClassCollectionNotSupported>
    {
        private readonly IReadOnlyCollection<ReadOnlyClass> classes;

        public ReadOnlyClassCollection(IEnumerable<Class> classes)
        {
            this.classes = classes.ToArray(@class => new ReadOnlyClass(@class));
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

        protected override IReadOnlyCollection<ReadOnlyClass> Classes
        {
            get { return classes; }
        }
    }
}
