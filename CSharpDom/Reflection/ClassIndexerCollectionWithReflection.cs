using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassIndexerCollectionWithReflection :
        AbstractClassIndexerCollection<ClassIndexerWithReflection, ExplicitInterfaceIndexerWithReflection>
    {
        private readonly ClassTypeWithReflection typeWithReflection;

        internal ClassIndexerCollectionWithReflection(ClassTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
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
