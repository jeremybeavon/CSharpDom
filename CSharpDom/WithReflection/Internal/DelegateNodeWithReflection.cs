using System;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class DelegateNodeWithReflection : DelegateNodeWithSymbols, IDelegateWithReflection, INestedDelegateWithReflection
    {
        private Type type;

        public DelegateNodeWithReflection(
            DelegateDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IDelegateWithSymbols Symbols
        {
            get { return this; }
        }

        public Type Type
        {
            get { return type ?? (type = BuildType()); }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        INamespaceWithReflection IHasNamespace<INamespaceWithReflection>.Namespace
        {
            get { return (INamespaceWithReflection)Namespace; }
        }

        IProjectWithReflection IHasProject<IProjectWithReflection>.Project
        {
            get { return (IProjectWithReflection)Project; }
        }

        ISolutionWithReflection IHasSolution<ISolutionWithReflection>.Solution
        {
            get { return (ISolutionWithReflection)Solution; }
        }

        INestedDelegateWithSymbols IHasSymbols<INestedDelegateWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }

        private Type BuildType()
        {
            return IsNestedType ? ReflectionHelper.FindType(this) : ReflectionHelper.FindNestedType(this);
        }
    }
}
