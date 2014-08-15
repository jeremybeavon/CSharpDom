using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class DelegateNodeWithLinqExpressions : DelegateNodeWithReflection, IDelegateWithLinqExpressions,
        INestedDelegateWithLinqExpressions
    {
        public DelegateNodeWithLinqExpressions(
            DelegateDeclarationSyntax declaration,
            ITypeContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IDelegateWithReflection Reflection
        {
            get { return this; }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        INamespaceWithLinqExpressions IHasNamespace<INamespaceWithLinqExpressions>.Namespace
        {
            get { return (INamespaceWithLinqExpressions)Namespace; }
        }

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        INestedDelegateWithReflection IHasReflection<INestedDelegateWithReflection>.Reflection
        {
            get { return this; }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }
    }
}
