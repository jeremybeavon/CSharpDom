using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class InterfaceDeclarationNodeWithLinqExpressions : InterfaceDeclarationNodeWithReflection,
        IInterfaceDeclarationWithLinqExpressions,
        INestedInterfaceDeclarationWithLinqExpressions
    {
        public InterfaceDeclarationNodeWithLinqExpressions(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container, 
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IInterfaceDeclarationWithReflection Reflection
        {
            get { return this; }
        }

        INestedInterfaceWithLinqExpressions IHasCompositeType<INestedInterfaceWithLinqExpressions>.CompositeType
        {
            get { return (INestedInterfaceWithLinqExpressions)CompositeType; }
        }

        IInterfaceWithLinqExpressions IHasCompositeType<IInterfaceWithLinqExpressions>.CompositeType
        {
            get { return (IInterfaceWithLinqExpressions)CompositeType; }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }

        IDocumentWithLinqExpressions IHasDocument<IDocumentWithLinqExpressions>.Document
        {
            get { return (IDocumentWithLinqExpressions)Document; }
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

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        IReadOnlyCollection<IPropertyWithLinqExpressions> IHasProperties<IPropertyWithLinqExpressions>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithLinqExpressions, PropertyNode>(Properties); }
        }

        INestedInterfaceDeclarationWithReflection IHasReflection<INestedInterfaceDeclarationWithReflection>.Reflection
        {
            get { return this; }
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
