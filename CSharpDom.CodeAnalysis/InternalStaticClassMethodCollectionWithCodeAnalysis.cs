using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassMethodCollectionWithCodeAnalysis<TClass> :
        StaticClassMethodCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> type;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly ClassMemberListWrapper<
            TClass,
            ExtensionMethodWithCodeAnalysis,
            MethodDeclarationSyntax> extensionMethods;

        internal InternalStaticClassMethodCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TClass> type)
        {
            this.type = type;
            methods = new ClassMemberListWrapper<TClass, StaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassMethodWithCodeAnalysis(),
                syntax => !IsExtensionMethod(syntax));
            extensionMethods = new ClassMemberListWrapper<TClass, ExtensionMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.InternalNode,
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
