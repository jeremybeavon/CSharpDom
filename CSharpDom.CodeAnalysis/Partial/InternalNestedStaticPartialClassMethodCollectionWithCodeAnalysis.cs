using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalNestedStaticPartialClassMethodCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticPartialClassMethodCollectionWithCodeAnalysis
        where TStaticClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> classType;
        private readonly ClassMethodListWrapper<TStaticClass, NestedStaticClassMethodWithCodeAnalysis> methods;
        private readonly ClassMethodListWrapper<TStaticClass, PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly ClassMethodListWrapper<TStaticClass, PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal InternalNestedStaticPartialClassMethodCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> classType)
        {
            this.classType = classType;
            methods = new ClassMethodListWrapper<TStaticClass, NestedStaticClassMethodWithCodeAnalysis>(
                classType.InternalNode,
                () => new NestedStaticClassMethodWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialMethodDefinitions = new ClassMethodListWrapper<TStaticClass, PartialMethodDefinitionWithCodeAnalysis>(
                classType.InternalNode,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new ClassMethodListWrapper<TStaticClass, PartialMethodImplementationWithCodeAnalysis>(
                classType.InternalNode,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
        }
        
        public override ICollection<NestedStaticClassMethodWithCodeAnalysis> Methods
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
