using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    internal sealed class InternalPartialStructMethodCollectionWithCodeAnalysis<TStruct> :
        PartialStructMethodCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructMethodListWrapper<TStruct, StructMethodWithCodeAnalysis> methods;
        private readonly StructMethodListWrapper<TStruct, PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly StructMethodListWrapper<TStruct, PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal InternalPartialStructMethodCollectionWithCodeAnalysis(
            InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            methods = new StructMethodListWrapper<TStruct, StructMethodWithCodeAnalysis>(
                structType.Node,
                () => new StructMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract() && !syntax.IsPartial());
            partialMethodDefinitions = new StructMethodListWrapper<TStruct, PartialMethodDefinitionWithCodeAnalysis>(
                structType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new StructMethodListWrapper<TStruct, PartialMethodImplementationWithCodeAnalysis>(
                structType.Node,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
        }
        
        public override ICollection<ExplicitInterfaceMethodWithCodeAnalysis> ExplicitInterfaceMethods
        {
            get { return structType.Methods.ExplicitInterfaceMethods; }
            set { structType.Methods.ExplicitInterfaceMethods = value; }
        }

        public override ICollection<StructMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { structType.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<PartialMethodDefinitionWithCodeAnalysis> PartialMethodDefinitions
        {
            get => partialMethodDefinitions;
            set => structType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }

        public override ICollection<PartialMethodImplementationWithCodeAnalysis> PartialMethodImplementations
        {
            get => partialMethodImplementations;
            set => structType.Members.CombineList(nameof(PartialMethodDefinitions), value.Select(item => item.Syntax));
        }
    }
}
