using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassNestedClassCollection :
        AbstractClassNestedClassCollection<
            ReadOnlyClassNestedClass,
            IClassNestedAbstractClass,
            IClassNestedSealedClass,
            IClassNestedStaticClass,
            IPartialClassCollection>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassNestedClass> classes;

        public ReadOnlyClassNestedClassCollection(ClassBody classBody)
        {
            classes = classBody.NestedClasses.ToArray(@class => new ReadOnlyClassNestedClass(@class));
        }

        public override IReadOnlyCollection<IClassNestedAbstractClass> AbstractClasses
        {
            get { return new IClassNestedAbstractClass[0]; }
        }

        public override IPartialClassCollection PartialClasses
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

        protected override IReadOnlyCollection<ReadOnlyClassNestedClass> Classes
        {
            get { return classes; }
        }
    }
}
