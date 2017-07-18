using CSharpDom.Editable.Partial;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassMethodCollectionWithCodeAnalysis :
        EditableStaticPartialClassMethodCollection<
            StaticPartialClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis>
    {
        private readonly StaticPartialClassWithCodeAnalysis classType;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly StaticPartialClassMemberListWrapper<
            ExtensionMethodWithCodeAnalysis,
            MethodDeclarationSyntax> extensionMethods;
        private readonly StaticPartialClassMemberListWrapper<
            PartialMethodDefinitionWithCodeAnalysis,
            MethodDeclarationSyntax> partialMethodDefinitions;
        private readonly StaticPartialClassMemberListWrapper<
            PartialMethodImplementationWithCodeAnalysis,
            MethodDeclarationSyntax> partialMethodImplementations;

        internal StaticPartialClassMethodCollectionWithCodeAnalysis(
            StaticPartialClassWithCodeAnalysis classType)
        {
            this.classType = classType;
            methods = new StaticPartialClassMemberListWrapper<StaticPartialClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.Node,
                () => new StaticPartialClassMethodWithCodeAnalysis(),
                syntax => !syntax.IsPartial());
            extensionMethods = new StaticPartialClassMemberListWrapper<ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.Node,
                () => new ExtensionMethodWithCodeAnalysis(),
                IsExtensionMethod);
            partialMethodDefinitions = new StaticPartialClassMemberListWrapper<PartialMethodDefinitionWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.Node,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new StaticPartialClassMemberListWrapper<PartialMethodImplementationWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.Node,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
        }

        public override ICollection<ExtensionMethodWithCodeAnalysis> ExtensionMethods
        {
            get { return extensionMethods; }
            set { classType.Members.CombineList(nameof(ExtensionMethods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassMethodWithCodeAnalysis> Methods
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

        private static bool IsExtensionMethod(MethodDeclarationSyntax syntax)
        {
            return syntax.ParameterList.Parameters.Count != 0 &&
                syntax.ParameterList.Parameters[0].Modifiers.Any(SyntaxKind.ThisKeyword);
        }
    }
}
