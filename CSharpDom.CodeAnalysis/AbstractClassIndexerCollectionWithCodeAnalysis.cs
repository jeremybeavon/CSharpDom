using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassIndexerCollectionWithCodeAnalysis :
        EditableAbstractClassIndexerCollection<
            ClassIndexerWithCodeAnalysis,
            AbstractIndexerWithCodeAnalysis,
            ExplicitInterfaceIndexerWithCodeAnalysis>
    {
        private readonly ClassTypeWithCodeAnalysis classType;
        private readonly ClassIndexerListWrapper<ClassIndexerWithCodeAnalysis> indexers;
        private readonly ClassIndexerListWrapper<AbstractIndexerWithCodeAnalysis> abstractIndexers;

        internal AbstractClassIndexerCollectionWithCodeAnalysis(ClassTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            indexers = new ClassIndexerListWrapper<ClassIndexerWithCodeAnalysis>(
                classType.Node,
                parent => new ClassIndexerWithCodeAnalysis(parent, ClassType.Abstract),
                (child, parent) => child.Indexer.Indexer.SetClassParent(parent, ClassType.Abstract),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractIndexers = new ClassIndexerListWrapper<AbstractIndexerWithCodeAnalysis>(
                classType.Node,
                parent => new AbstractIndexerWithCodeAnalysis(parent),
                (child, parent) => child.Indexer.AbstractClassParent = parent,
                syntax => syntax.Modifiers.IsAbstract());
        }

        public override ICollection<AbstractIndexerWithCodeAnalysis> AbstractIndexers
        {
            get { return abstractIndexers; }
            set { classType.Members.CombineList(nameof(AbstractIndexers), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ExplicitInterfaceIndexerWithCodeAnalysis> ExplicitInterfaceIndexers
        {
            get { return classType.Indexers.ExplicitInterfaceIndexers; }
            set { classType.Indexers.ExplicitInterfaceIndexers = value; }
        }

        public override ICollection<ClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { classType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> AbstractIndexerList
        {
            get { return abstractIndexers; }
        }
        
        internal IChildCollection<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> IndexerList
        {
            get { return indexers; }
        }
    }
}
