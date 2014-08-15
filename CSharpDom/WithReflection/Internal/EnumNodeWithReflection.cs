using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class EnumNodeWithReflection : EnumNodeWithSymbols, IEnumWithReflection, INestedEnumWithReflection
    {
        public EnumNodeWithReflection(
            EnumDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IEnumWithSymbols Symbols
        {
            get { return this; }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        IReadOnlyCollection<INestedEnumMemberWithReflection> IHasEnumMembers<INestedEnumMemberWithReflection>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<INestedEnumMemberWithReflection, EnumMemberNode>(EnumMembers); }
        }

        IReadOnlyCollection<IEnumMemberWithReflection> IHasEnumMembers<IEnumMemberWithReflection>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<IEnumMemberWithReflection, EnumMemberNode>(EnumMembers); }
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

        INestedEnumWithSymbols IHasSymbols<INestedEnumWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
