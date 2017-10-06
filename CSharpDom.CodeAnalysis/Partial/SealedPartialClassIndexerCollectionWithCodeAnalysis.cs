using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassIndexerCollectionWithCodeAnalysis :
        EditableSealedClassIndexerCollection<
            SealedPartialClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly SealedClassIndexerCollectionWithCodeAnalysis indexerCollection;
        private readonly WrappedCollection<
            SealedClassIndexerWithCodeAnalysis,
            SealedPartialClassIndexerWithCodeAnalysis> indexers;
        
        internal SealedPartialClassIndexerCollectionWithCodeAnalysis(
            SealedClassIndexerCollectionWithCodeAnalysis indexerCollection)
        {
            this.indexerCollection = indexerCollection;
            indexers = new WrappedCollection<SealedClassIndexerWithCodeAnalysis, SealedPartialClassIndexerWithCodeAnalysis>(
                indexerCollection.Indexers,
                parent => new SealedPartialClassIndexerWithCodeAnalysis(parent),
                child => child.Indexer,
                value => indexerCollection.Indexers = value);
        }
        
        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return indexerCollection.ExplicitInterfaceIndexers; }
            set { indexerCollection.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<SealedPartialClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { indexers.Replace(value); }
        }
    }
}
