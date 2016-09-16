﻿using System;
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
                () => new ClassIndexerWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract());
            abstractIndexers = new ClassIndexerListWrapper<AbstractIndexerWithCodeAnalysis>(
                classType.Node,
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

        public override ICollection<ClassIndexerWithCodeAnalysis> Indexers
        {
            get { return indexers; }
            set { classType.Members.CombineList(nameof(Indexers), value.Select(item => item.Syntax)); }
        }
    }
}
