using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructIndexerCollectionWithCodeAnalysis<TStruct> :
        StructIndexerCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            ExplicitInterfaceIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> explicitInterfaceIndexers;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructIndexerWithCodeAnalysis,
            IndexerDeclarationSyntax> indexers;

        internal InternalStructIndexerCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            explicitInterfaceIndexers = new StructTypeMemberListWrapper<TStruct, ExplicitInterfaceIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                structType.Node,
                () => new ExplicitInterfaceIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new StructTypeMemberListWrapper<TStruct, StructIndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
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
