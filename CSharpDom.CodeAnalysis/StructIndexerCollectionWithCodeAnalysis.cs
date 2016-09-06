using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructIndexerCollectionWithCodeAnalysis :
        EditableStructIndexerCollection<StructIndexerWithCodeAnalysis, ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<
            IndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> explicitInterfaceIndexers;
        private readonly StructTypeMemberListWrapper<
            IndexerWithCodeAnalysis,
            StructIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> indexers;

        internal StructIndexerCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            explicitInterfaceIndexers = new StructTypeMemberListWrapper<IndexerWithCodeAnalysis, ExplicitInterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                structType.Node,
                parent => new ExplicitInterfaceIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.Indexer.ExplicitInterfaceStructParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new StructTypeMemberListWrapper<IndexerWithCodeAnalysis, StructIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                structType.Node,
                parent => new StructIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.Indexer.StructParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return explicitInterfaceIndexers; }
            set { structType.Members.CombineList(nameof(ExplicitInterfaceIndexers), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { structType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> ExplicitInterfaceIndexerList
        {
            get { return explicitInterfaceIndexers; }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }
    }
}
