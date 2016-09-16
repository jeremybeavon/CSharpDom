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
            ExplicitInterfaceIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> explicitInterfaceIndexers;
        private readonly StructTypeMemberListWrapper<StructIndexerWithCodeAnalysis, IndexerDeclarationSyntax> indexers;

        internal StructIndexerCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            explicitInterfaceIndexers = new StructTypeMemberListWrapper<ExplicitInterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfaceIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new StructTypeMemberListWrapper<StructIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                structType.Node,
                () => new StructIndexerWithCodeAnalysis(),
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
    }
}
