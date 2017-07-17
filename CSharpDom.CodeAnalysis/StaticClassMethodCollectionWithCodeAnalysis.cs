using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassMethodCollectionWithCodeAnalysis :
        EditableStaticClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticClassMemberListWrapper<
            StaticClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly StaticClassMemberListWrapper<
            ExtensionMethodWithCodeAnalysis,
            MethodDeclarationSyntax> extensionMethods;

        internal StaticClassMethodCollectionWithCodeAnalysis(StaticClassWithCodeAnalysis type)
        {
            this.type = type;
            methods = new StaticClassMemberListWrapper<StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                syntax => !IsExtensionMethod(syntax));
            extensionMethods = new StaticClassMemberListWrapper<ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new ExtensionMethodWithCodeAnalysis(),
                IsExtensionMethod);
        }

        public override ICollection<ExtensionMethodWithCodeAnalysis> ExtensionMethods
        {
            get { return extensionMethods; }
            set { type.Members.CombineList(nameof(ExtensionMethods), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { type.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }

        }

        private static bool IsExtensionMethod(MethodDeclarationSyntax syntax)
        {
            return syntax.ParameterList.Parameters.Count != 0 &&
                syntax.ParameterList.Parameters[0].Modifiers.Any(SyntaxKind.ThisKeyword);
        }
    }
}
