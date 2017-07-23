using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalSealedClassIndexerCollectionWithCodeAnalysis<TClass> :
        SealedClassIndexerCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassIndexerListWrapper<TClass, SealedClassIndexerWithCodeAnalysis> indexers;

        internal InternalSealedClassIndexerCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            indexers = new ClassIndexerListWrapper<TClass, SealedClassIndexerWithCodeAnalysis>(
                classType.InternalNode,
                () => new SealedClassIndexerWithCodeAnalysis(),
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
    }
}
