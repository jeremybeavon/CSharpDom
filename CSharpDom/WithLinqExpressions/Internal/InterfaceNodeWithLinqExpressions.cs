using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class InterfaceNodeWithLinqExpressions : InterfaceNodeWithReflection, IInterfaceWithLinqExpressions,
        INestedInterfaceWithLinqExpressions
    {
        public InterfaceNodeWithLinqExpressions(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public IInterfaceWithReflection Reflection
        {
            get { return this; }
        }

        IReadOnlyCollection<IInterfaceDeclarationWithLinqExpressions> IHasDeclarations<IInterfaceDeclarationWithLinqExpressions>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IInterfaceDeclarationWithLinqExpressions, InterfaceDeclarationNode>(Declarations); }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        IReadOnlyCollection<IEventWithLinqExpressions> IHasEvents<IEventWithLinqExpressions>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithLinqExpressions, EventNode>(Events); }
        }

        IReadOnlyCollection<IIndexerWithLinqExpressions> IHasIndexers<IIndexerWithLinqExpressions>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithLinqExpressions, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<IMethodWithLinqExpressions> IHasMethods<IMethodWithLinqExpressions>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithLinqExpressions, MethodNode>(Methods); }
        }

        INamespaceWithLinqExpressions IHasNamespace<INamespaceWithLinqExpressions>.Namespace
        {
            get { return (INamespaceWithLinqExpressions)Namespace; }
        }

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        IReadOnlyCollection<IPropertyWithLinqExpressions> IHasProperties<IPropertyWithLinqExpressions>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithLinqExpressions, PropertyNode>(Properties); }
        }

        INestedInterfaceWithReflection IHasReflection<INestedInterfaceWithReflection>.Reflection
        {
            get { return this; }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }
    }
}
