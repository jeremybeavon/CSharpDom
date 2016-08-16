using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassIndexerCollectionWithCodeAnalysis :
        AbstractSealedClassIndexerCollection<
            SealedClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly SealedTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal SealedClassIndexerCollectionWithCodeAnalysis(SealedTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }
        
        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<SealedClassIndexerWithCodeAnalysis> Indexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.IndexersWithCodeAnalysis; }
        }
    }
}
