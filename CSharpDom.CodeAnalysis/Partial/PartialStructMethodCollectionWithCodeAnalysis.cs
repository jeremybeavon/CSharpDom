using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructMethodCollectionWithCodeAnalysis :
        EditablePartialStructMethodCollection<
            StructMethodWithCodeAnalysis,
            ExplicitInterfaceMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructMethodListWrapper<StructMethodWithCodeAnalysis> methods;
        private readonly StructMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly StructMethodListWrapper<PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal PartialStructMethodCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            methods = new StructMethodListWrapper<StructMethodWithCodeAnalysis>(
                structType.Node,
                () => new StructMethodWithCodeAnalysis(),
                syntax => syntax.ExplicitInterfaceSpecifier == null && !syntax.Modifiers.IsAbstract() && !syntax.IsPartial());
            partialMethodDefinitions = new StructMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis>(
                structType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new StructMethodListWrapper<PartialMethodImplementationWithCodeAnalysis>(
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
