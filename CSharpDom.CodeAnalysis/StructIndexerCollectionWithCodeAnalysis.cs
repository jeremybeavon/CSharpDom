using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructIndexerCollectionWithCodeAnalysis :
        AbstractStructIndexerCollection<StructIndexerWithCodeAnalysis, ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal StructIndexerCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<StructIndexerWithCodeAnalysis> Indexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.IndexersWithCodeAnalysis; }
        }
    }
}
