using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassIndexerCollection :
        AbstractClassIndexerCollection<ReadOnlyClassIndexer, ReadOnlyExplicitInterfaceIndexer>
    {
        private readonly IReadOnlyCollection<ReadOnlyClassIndexer> indexers;
        private readonly IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> explicitInterfaceIndexers;

        public ReadOnlyClassIndexerCollection(ClassBody body)
        {
            indexers = body.Indexers.ToArray(indexer => new ReadOnlyClassIndexer(indexer));
            explicitInterfaceIndexers = body.ExplicitInterfaceIndexers.ToArray(indexer => new ReadOnlyExplicitInterfaceIndexer(indexer));
        }

        public override IReadOnlyCollection<ReadOnlyExplicitInterfaceIndexer> ExplicitInterfaceIndexers
        {
            get { return explicitInterfaceIndexers; }
        }

        protected override IReadOnlyCollection<ReadOnlyClassIndexer> Indexers
        {
            get { return indexers; }
        }
    }
}
