using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalNestedStaticPartialClassMethodCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticPartialClassMethodCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> classType;
        private readonly StaticClassMethodListWrapper<TStaticClass, StaticClassMethodWithCodeAnalysis> methods;
        private readonly StaticClassMethodListWrapper<TStaticClass, PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly StaticClassMethodListWrapper<TStaticClass, PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal InternalNestedStaticPartialClassMethodCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<TStaticClass> classType)
        {
            this.classType = classType;
            methods = new StaticClassMethodListWrapper<TStaticClass, StaticClassMethodWithCodeAnalysis>(
                classType.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialMethodDefinitions = new StaticClassMethodListWrapper<TStaticClass, PartialMethodDefinitionWithCodeAnalysis>(
                classType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new StaticClassMethodListWrapper<TStaticClass, PartialMethodImplementationWithCodeAnalysis>(
                classType.Node,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
        }
        
        public override ICollection<StaticClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { classType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<PartialMethodDefinitionWithCodeAnalysis> PartialMethodDefinitions
        {
            get => partialMethodDefinitions;
            set => classType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }

        public override ICollection<PartialMethodImplementationWithCodeAnalysis> PartialMethodImplementations
        {
            get => partialMethodImplementations;
            set => classType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }
    }
}
