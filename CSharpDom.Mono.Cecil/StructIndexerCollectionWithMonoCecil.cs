using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructIndexerCollectionWithMonoCecil :
        AbstractStructIndexerCollection<StructIndexerWithMonoCecil, ExplicitInterfaceIndexerWithMonoCecil>
    {
        private readonly StructTypeWithMonoCecil typeWithMonoCecil;

        internal StructIndexerCollectionWithMonoCecil(StructTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithMonoCecil> ExplicitInterfaceIndexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithMonoCecil; }
        }

        protected override IReadOnlyCollection<StructIndexerWithMonoCecil> Indexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.IndexersWithMonoCecil; }
        }
    }
}
