using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassMethodCollectionWithCodeAnalysis<TStaticClass> :
        StaticClassMethodCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> type;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            ExtensionMethodWithCodeAnalysis,
            MethodDeclarationSyntax> extensionMethods;

        internal InternalStaticClassMethodCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            methods = new StaticTypeMemberListWrapper<TStaticClass, StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.Node,
                () => new StaticClassMethodWithCodeAnalysis(),
                IsExtensionMethod);
            extensionMethods = new StaticTypeMemberListWrapper<TStaticClass, ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
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
