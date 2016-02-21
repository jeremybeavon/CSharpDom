using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class AbstractClassIndexerCollectionWithReflection :
        AbstractAbstractClassIndexerCollection<
            ClassIndexerWithReflection,
            AbstractIndexerWithReflection,
            ExplicitInterfaceIndexerWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal AbstractClassIndexerCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }

        public override IReadOnlyCollection<AbstractIndexerWithReflection> AbstractIndexers
        {
            get { return typeWithReflection.IndexerCollection.Indexers.AbstractIndexersWithReflection; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return typeWithReflection.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithReflection; }
        }

        protected override IReadOnlyCollection<ClassIndexerWithReflection> Indexers
        {
            get { return typeWithReflection.IndexerCollection.Indexers.IndexersWithReflection; }
        }
    }
}
