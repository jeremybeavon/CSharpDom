using CSharpDom.BaseClasses.Editable.Partial;
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
        private readonly InternalStaticTypeWithCodeAnalysis<StaticPartialClassWithCodeAnalysis> classType;
        private readonly ClassMemberListWrapper<
            StaticPartialClassWithCodeAnalysis,
            StaticPartialClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        private readonly ClassMemberListWrapper<
            StaticPartialClassWithCodeAnalysis,
            PartialMethodDefinitionWithCodeAnalysis,
            MethodDeclarationSyntax> partialMethodDefinitions;
        private readonly ClassMemberListWrapper<
            StaticPartialClassWithCodeAnalysis,
            PartialMethodImplementationWithCodeAnalysis,
            MethodDeclarationSyntax> partialMethodImplementations;

        internal StaticPartialClassMethodCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<StaticPartialClassWithCodeAnalysis> classType)
        {
            this.classType = classType;
            methods = new ClassMemberListWrapper<StaticPartialClassWithCodeAnalysis, StaticPartialClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.InternalNode,
                () => new StaticPartialClassMethodWithCodeAnalysis(new StaticClassMethodWithCodeAnalysis()),
                syntax => !syntax.IsPartial());
            partialMethodDefinitions = new ClassMemberListWrapper<StaticPartialClassWithCodeAnalysis, PartialMethodDefinitionWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.InternalNode,
                () => new PartialMethodDefinitionWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body == null);
            partialMethodImplementations = new ClassMemberListWrapper<StaticPartialClassWithCodeAnalysis, PartialMethodImplementationWithCodeAnalysis, MethodDeclarationSyntax>(
                classType.InternalNode,
                () => new PartialMethodImplementationWithCodeAnalysis(),
                syntax => syntax.IsPartial() && syntax.Body != null);
        }

        public override ICollection<ExtensionMethodWithCodeAnalysis> ExtensionMethods
        {
            get { return classType.Methods.ExtensionMethods; }
            set { classType.Methods.ExtensionMethods = value; }
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
