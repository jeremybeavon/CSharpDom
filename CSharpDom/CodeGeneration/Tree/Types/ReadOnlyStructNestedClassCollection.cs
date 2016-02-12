using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructNestedClassCollection :
        AbstractStructNestedClassCollection<
            ReadOnlyStructNestedClass,
            IStructNestedAbstractClass,
            IStructNestedSealedClass,
            IStructNestedStaticClass,
            IPartialClassCollection>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructNestedClass> classes;

        public ReadOnlyStructNestedClassCollection(StructBody structBody)
        {
            classes = structBody.NestedClasses.ToArray(@class => new ReadOnlyStructNestedClass(@class));
        }

        public override IReadOnlyCollection<IStructNestedAbstractClass> AbstractClasses
        {
            get { return new IStructNestedAbstractClass[0]; }
        }

        public override IPartialClassCollection PartialClasses
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

        protected override IReadOnlyCollection<ReadOnlyStructNestedClass> Classes
        {
            get { return classes; }
        }
    }
}
