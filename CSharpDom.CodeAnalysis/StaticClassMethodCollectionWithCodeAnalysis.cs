using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassMethodCollectionWithCodeAnalysis :
        EditableStaticClassMethodCollection<
            StaticClassMethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly StaticTypeMemberListWrapper<StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax> methods;
        private readonly StaticTypeMemberListWrapper<ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax> extensionMethods;

        internal StaticClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            methods = new StaticTypeMemberListWrapper<StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                IsExtensionMethod);
            extensionMethods = new StaticTypeMemberListWrapper<ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new ExtensionMethodWithCodeAnalysis(),
                syntax => !IsExtensionMethod(syntax));
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
