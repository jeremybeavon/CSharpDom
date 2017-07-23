using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalAbstractClassIndexerCollectionWithCodeAnalysis<TClass> :
        AbstractClassIndexerCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassIndexerListWrapper<TClass, AbstractClassIndexerWithCodeAnalysis> indexers;
        private readonly ClassIndexerListWrapper<TClass, AbstractIndexerWithCodeAnalysis> abstractIndexers;

        internal InternalAbstractClassIndexerCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            indexers = new ClassIndexerListWrapper<TClass, AbstractClassIndexerWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractClassIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractIndexers = new ClassIndexerListWrapper<TClass, AbstractIndexerWithCodeAnalysis>(
                classType.InternalNode,
                () => new AbstractIndexerWithCodeAnalysis(),
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

        public override ICollection<AbstractClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { classType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }
    }
}
