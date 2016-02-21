using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassIndexerCollectionWithReflection :
        AbstractSealedClassIndexerCollection<
            SealedClassIndexerWithReflection,
            ExplicitInterfaceIndexerWithReflection>
    {
        private readonly SealedTypeWithReflection typeWithReflection;

        internal SealedClassIndexerCollectionWithReflection(SealedTypeWithReflection typeWithReflection)
        {
            this.typeWithReflection = typeWithReflection;
        }
        
        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithReflection> ExplicitInterfaceIndexers
        {
            get { return typeWithReflection.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithReflection; }
        }

        protected override IReadOnlyCollection<SealedClassIndexerWithReflection> Indexers
        {
            get { return typeWithReflection.IndexerCollection.Indexers.IndexersWithReflection; }
        }
    }
}
