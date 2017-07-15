using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalClassIndexerCollectionWithCodeAnalysis<TClass> :
        ClassIndexerCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalClassTypeWithCodeAnalysis<TClass> classType;
        private readonly ClassIndexerListWrapper<TClass, ExplicitInterfaceIndexerWithCodeAnalysis> explicitInterfaceIndexers;
        private readonly ClassIndexerListWrapper<TClass, ClassIndexerWithCodeAnalysis> indexers;

        internal InternalClassIndexerCollectionWithCodeAnalysis(InternalClassTypeWithCodeAnalysis<TClass> classType)
        {
            this.classType = classType;
            explicitInterfaceIndexers = new ClassIndexerListWrapper<TClass, ExplicitInterfaceIndexerWithCodeAnalysis>(
                classType.Node,
                () => new ExplicitInterfaceIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new ClassIndexerListWrapper<TClass, ClassIndexerWithCodeAnalysis>(
                classType.Node,
                () => new ClassIndexerWithCodeAnalysis(),
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
    }
}
