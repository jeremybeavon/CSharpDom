using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class EnumNodeWithLinqExpressions : EnumNodeWithReflection, IEnumWithLinqExpressions, INestedEnumWithLinqExpressions
    {
        public EnumNodeWithLinqExpressions(
            EnumDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        IReadOnlyCollection<INestedEnumMemberWithLinqExpressions> IHasEnumMembers<INestedEnumMemberWithLinqExpressions>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<INestedEnumMemberWithLinqExpressions, EnumMemberNode>(EnumMembers); }
        }

        IReadOnlyCollection<IEnumMemberWithLinqExpressions> IHasEnumMembers<IEnumMemberWithLinqExpressions>.EnumMembers
        {
            get { return new ReadOnlyNodeCollection<IEnumMemberWithLinqExpressions, EnumMemberNode>(EnumMembers); }
        }

        INamespaceWithLinqExpressions IHasNamespace<INamespaceWithLinqExpressions>.Namespace
        {
            get { return (INamespaceWithLinqExpressions)Namespace; }
        }

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
