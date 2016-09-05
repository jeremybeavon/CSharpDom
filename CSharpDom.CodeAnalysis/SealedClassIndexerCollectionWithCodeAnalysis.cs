using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassIndexerCollectionWithCodeAnalysis :
        EditableSealedClassIndexerCollection<
            SealedClassIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassIndexerListWrapper<SealedClassIndexerWithCodeAnalysis> indexers;

        internal SealedClassIndexerCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            indexers = new ClassIndexerListWrapper<SealedClassIndexerWithCodeAnalysis>(
                classType.Node,
                parent => new SealedClassIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.Indexer.SealedClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }
        
        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return classType.Indexers.ExplicitInterfaceIndexers; }
            set { classType.Indexers.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<SealedClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { classType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }
    }
}
