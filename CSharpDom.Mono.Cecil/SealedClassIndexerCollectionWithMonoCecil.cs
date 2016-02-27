using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassIndexerCollectionWithMonoCecil :
        AbstractSealedClassIndexerCollection<
            SealedClassIndexerWithMonoCecil,
            ExplicitInterfaceIndexerWithMonoCecil>
    {
        private readonly SealedTypeWithMonoCecil typeWithMonoCecil;

        internal SealedClassIndexerCollectionWithMonoCecil(SealedTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }
        
        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithMonoCecil> ExplicitInterfaceIndexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithMonoCecil; }
        }

        protected override IReadOnlyCollection<SealedClassIndexerWithMonoCecil> Indexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.IndexersWithMonoCecil; }
        }
    }
}
