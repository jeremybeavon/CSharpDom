using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructIndexerCollection :
        AbstractStructIndexerCollection<ReadOnlyStructIndexer, ReadOnlyExplicitInterfaceIndexer>
    {
        private readonly IReadOnlyCollection<ReadOnlyStructIndexer> indexers;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> explicitInterfaceIndexers;

        public ReadOnlyStructIndexerCollection(StructBody body)
        {
            indexers = body.Indexers.ToArray(indexer => new ReadOnlyStructIndexer(indexer));
            explicitInterfaceIndexers = body.ExplicitInterfaceIndexers.ToArray(indexer => new ReadOnlyExplicitInterfaceIndexer(indexer));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> ExplicitInterfaceIndexers
        {
            get { return explicitInterfaceIndexers; }
        }

        protected override IReadOnlyCollection<ReadOnlyStructIndexer> Indexers
        {
            get { return indexers; }
        }
    }
}
