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
                () => new ExplicitInterfaceIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier != null);
            indexers = new ClassIndexerListWrapper<ClassIndexerWithCodeAnalysis>(
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
