using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassIndexerCollectionWithCodeAnalysis :
        EditableClassIndexerCollection<ClassIndexerWithCodeAnalysis, ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassIndexerListWrapper<ExplicitInterfaceIndexerWithCodeAnalysis> explicitInterfaceIndexers;
        private readonly ClassIndexerListWrapper<ClassIndexerWithCodeAnalysis> indexers;

        internal ClassIndexerCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            explicitInterfaceIndexers = new ClassIndexerListWrapper<ExplicitInterfaceIndexerWithCodeAnalysis>(
                classType.Node,
                parent => new ExplicitInterfaceIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.Indexer.ExplicitInterfaceClassParent = parent,
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new ClassIndexerListWrapper<ClassIndexerWithCodeAnalysis>(
                classType.Node,
                parent => new ClassIndexerWithCodeAnalysis(parent, ClassType.Normal),
                (child, parent) => child.Indexer.Indexer.SetClassParent(parent, ClassType.Normal),
                syntax => syntax.ExplicitInterfaceSpecifier == null);
        }

        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return explicitInterfaceIndexers; }
            set { classType.Members.CombineList(nameof(ExplicitInterfaceIndexers), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { classType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> ExplicitInterfaceIndexerList
        {
            get { return explicitInterfaceIndexers; }
        }
    }
}
