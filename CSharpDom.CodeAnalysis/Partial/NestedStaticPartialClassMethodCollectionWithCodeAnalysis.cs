using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableNestedStaticPartialClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis classType;
        private readonly StaticClassMethodListWrapper<StaticClassMethodWithCodeAnalysis> methods;
        private readonly StaticClassMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly StaticClassMethodListWrapper<PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal NestedStaticPartialClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis classType)
        {
            this.classType = classType;
            methods = new StaticClassMethodListWrapper<StaticClassMethodWithCodeAnalysis>(
                classType.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            partialMethodDefinitions = new StaticClassMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis>(
                classType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new StaticClassMethodListWrapper<PartialMethodImplementationWithCodeAnalysis>(
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

        internal void Replace(NestedStaticPartialClassMethodCollectionWithCodeAnalysis value)
        {
            classType.Members.CombineList(
                new MemberListSyntax(nameof(Methods), value.Methods.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(PartialMethodDefinitions), value.PartialMethodDefinitions.Select(method => method.Syntax)),
                new MemberListSyntax(nameof(PartialMethodImplementations), value.PartialMethodImplementations.Select(method => method.Syntax)));
        }
    }
}
