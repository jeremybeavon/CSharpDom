using System.Collections.Generic;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassIndexerCollectionWithCodeAnalysis :
        EditableAbstractClassIndexerCollection<
            AbstractPartialClassIndexerWithCodeAnalysis,
            AbstractPartialClassAbstractIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly AbstractClassIndexerCollectionWithCodeAnalysis indexerCollection;
        private readonly WrappedCollection<
            AbstractClassIndexerWithCodeAnalysis,
            AbstractPartialClassIndexerWithCodeAnalysis> indexers;
        private readonly WrappedCollection<
            AbstractIndexerWithCodeAnalysis,
            AbstractPartialClassAbstractIndexerWithCodeAnalysis> abstractIndexers;

        internal AbstractPartialClassIndexerCollectionWithCodeAnalysis(
            AbstractClassIndexerCollectionWithCodeAnalysis indexerCollection)
        {
            this.indexerCollection = indexerCollection;
            indexers = new WrappedCollection<AbstractClassIndexerWithCodeAnalysis, AbstractPartialClassIndexerWithCodeAnalysis>(
                indexerCollection.Indexers,
                parent => new AbstractPartialClassIndexerWithCodeAnalysis(parent),
                child => child.InternalIndexer,
                value => indexerCollection.Indexers = value);
            abstractIndexers = new WrappedCollection<AbstractIndexerWithCodeAnalysis, AbstractPartialClassAbstractIndexerWithCodeAnalysis>(
                indexerCollection.AbstractIndexers,
                parent => new AbstractPartialClassAbstractIndexerWithCodeAnalysis(parent),
                child => child.InternalIndexer,
                value => indexerCollection.AbstractIndexers = value);
        }

        public override ICollection<AbstractPartialClassAbstractIndexerWithCodeAnalysis> AbstractIndexers
        {
            get { return abstractIndexers; }
            set { abstractIndexers.Replace(value); }
        }

        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return indexerCollection.ExplicitInterfaceIndexers; }
            set { indexerCollection.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<AbstractPartialClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { indexers.Replace(value); }
        }
    }
}
