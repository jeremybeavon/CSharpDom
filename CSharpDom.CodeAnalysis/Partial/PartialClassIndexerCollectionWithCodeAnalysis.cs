using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassIndexerCollectionWithCodeAnalysis :
        EditableClassIndexerCollection<
            PartialClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly ClassIndexerCollectionWithCodeAnalysis indexerCollection;
        private readonly WrappedCollection<
            ClassIndexerWithCodeAnalysis,
            PartialClassIndexerWithCodeAnalysis> indexers;
        
        internal PartialClassIndexerCollectionWithCodeAnalysis(
            ClassIndexerCollectionWithCodeAnalysis indexerCollection)
        {
            this.indexerCollection = indexerCollection;
            indexers = new WrappedCollection<ClassIndexerWithCodeAnalysis, PartialClassIndexerWithCodeAnalysis>(
                indexerCollection.Indexers,
                parent => new PartialClassIndexerWithCodeAnalysis(parent),
                child => child.Indexer,
                value => indexerCollection.Indexers = value);
        }
        
        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return indexerCollection.ExplicitInterfaceIndexers; }
            set { indexerCollection.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<PartialClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { indexers.Replace(value); }
        }
    }
}
