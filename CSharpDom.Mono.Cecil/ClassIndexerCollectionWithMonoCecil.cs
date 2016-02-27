using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassIndexerCollectionWithMonoCecil :
        AbstractClassIndexerCollection<ClassIndexerWithMonoCecil, ExplicitInterfaceIndexerWithMonoCecil>
    {
        private readonly ClassTypeWithMonoCecil typeWithMonoCecil;

        internal ClassIndexerCollectionWithMonoCecil(ClassTypeWithMonoCecil typeWithMonoCecil)
        {
            this.typeWithMonoCecil = typeWithMonoCecil;
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithMonoCecil> ExplicitInterfaceIndexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithMonoCecil; }
        }

        protected override IReadOnlyCollection<ClassIndexerWithMonoCecil> Indexers
        {
            get { return typeWithMonoCecil.IndexerCollection.Indexers.IndexersWithMonoCecil; }
        }
    }
}
