using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassIndexerCollectionWithCodeAnalysis :
        AbstractAbstractClassIndexerCollection<
            ClassIndexerWithCodeAnalysis,
            AbstractIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis typeWithCodeAnalysis;

        internal AbstractClassIndexerCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis typeWithCodeAnalysis)
        {
            this.typeWithCodeAnalysis = typeWithCodeAnalysis;
        }

        public override IReadOnlyCollection<AbstractIndexerWithCodeAnalysis> AbstractIndexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.AbstractIndexersWithCodeAnalysis; }
        }

        public override IReadOnlyCollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.ExplicitInterfaceIndexersWithCodeAnalysis; }
        }

        protected override IReadOnlyCollection<ClassIndexerWithCodeAnalysis> Indexers
        {
            get { return typeWithCodeAnalysis.IndexerCollection.Indexers.IndexersWithCodeAnalysis; }
        }
    }
}
