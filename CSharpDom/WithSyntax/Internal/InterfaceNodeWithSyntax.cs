using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class InterfaceNodeWithSyntax : InterfaceNode, IInterfaceSyntax, INestedInterfaceSyntax
    {
        public InterfaceNodeWithSyntax(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        IReadOnlyCollection<INestedInterfaceDeclarationSyntax> IHasDeclarations<INestedInterfaceDeclarationSyntax>.Declarations
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceDeclarationSyntax, InterfaceDeclarationNode>(Declarations); }
        }

        IReadOnlyCollection<IInterfaceDeclarationSyntax> IHasDeclarations<IInterfaceDeclarationSyntax>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IInterfaceDeclarationSyntax, InterfaceDeclarationNode>(Declarations); }
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        IReadOnlyCollection<IEventSyntax> IHasEvents<IEventSyntax>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventSyntax, EventNode>(Events); }
        }

        IReadOnlyCollection<IIndexerSyntax> IHasIndexers<IIndexerSyntax>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerSyntax, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<IMethodSyntax> IHasMethods<IMethodSyntax>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodSyntax, MethodNode>(Methods); }
        }

        INamespaceSyntax IHasNamespace<INamespaceSyntax>.Namespace
        {
            get { return (INamespaceSyntax)Namespace; }
        }

        IProjectSyntax IHasProject<IProjectSyntax>.Project
        {
            get { return (IProjectSyntax)Project; }
        }

        IReadOnlyCollection<IPropertySyntax> IHasProperties<IPropertySyntax>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertySyntax, PropertyNode>(Properties); }
        }

        ISolutionSyntax IHasSolution<ISolutionSyntax>.Solution
        {
            get { return (ISolutionSyntax)Solution; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return IsNestedType ? (AbstractSyntaxNode)new NestedInterfaceWithSyntax(this) : new InterfaceWithSyntax(this);
        }
    }
}
