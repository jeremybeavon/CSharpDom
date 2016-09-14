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
        private readonly StaticTypeMemberListWrapper<
            MethodWithCodeAnalysis,
            StaticClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly StaticTypeMemberListWrapper<
            MethodWithCodeAnalysis,
            ExtensionMethodWithCodeAnalysis,
            MethodDeclarationSyntax> extensionMethods;

        internal StaticClassMethodCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            methods = new StaticTypeMemberListWrapper<MethodWithCodeAnalysis, StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                IsExtensionMethod);
            extensionMethods = new StaticTypeMemberListWrapper<MethodWithCodeAnalysis, ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
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

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> ExtensionMethodList
        {
            get { return extensionMethods; }
        }

        internal IChildCollection<MethodWithCodeAnalysis, MethodDeclarationSyntax> MethodList
        {
            get { return methods; }
        }

        private static bool IsExtensionMethod(MethodDeclarationSyntax syntax)
        {
            return syntax.ParameterList.Parameters.Count != 0 &&
                syntax.ParameterList.Parameters[0].Modifiers.Any(SyntaxKind.ThisKeyword);
        }
    }
}
