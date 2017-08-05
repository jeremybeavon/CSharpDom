using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructIndexerCollectionWithCodeAnalysis :
        EditableStructIndexerCollection<
            PartialStructIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly StructIndexerCollectionWithCodeAnalysis indexerCollection;
        private readonly WrappedCollection<
            StructIndexerWithCodeAnalysis,
            PartialStructIndexerWithCodeAnalysis> indexers;
        
        internal PartialStructIndexerCollectionWithCodeAnalysis(
            StructIndexerCollectionWithCodeAnalysis indexerCollection)
        {
            this.indexerCollection = indexerCollection;
            indexers = new WrappedCollection<StructIndexerWithCodeAnalysis, PartialStructIndexerWithCodeAnalysis>(
                indexerCollection.Indexers,
                parent => new PartialStructIndexerWithCodeAnalysis(parent),
                child => child.Indexer,
                value => indexerCollection.Indexers = value);
        }
        
        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return indexerCollection.ExplicitInterfaceIndexers; }
            set { indexerCollection.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<PartialStructIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { indexers.Replace(value); }
        }
    }
}
