using System;
using System.Collections.Generic;
using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableStaticPartialClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis classType;
        private readonly StaticClassMethodListWrapper<StaticClassMethodWithCodeAnalysis> methods;
        private readonly StaticClassMethodListWrapper<PartialMethodDefinitionWithCodeAnalysis> partialMethodDefinitions;
        private readonly StaticClassMethodListWrapper<PartialMethodImplementationWithCodeAnalysis> partialMethodImplementations;

        internal StaticPartialClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis classType)
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
        
        public override ICollection<ExtensionMethodWithCodeAnalysis> ExtensionMethods
        {
            get { return classType.Methods.ExtensionMethods; }
            set { classType.Methods.ExtensionMethods = value; }
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
