using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class InterfaceDeclarationNodeWithSyntax : InterfaceDeclarationNode, IInterfaceDeclarationSyntax,
        INestedInterfaceDeclarationSyntax
    {
        public InterfaceDeclarationNodeWithSyntax(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        INestedInterfaceSyntax IHasCompositeType<INestedInterfaceSyntax>.CompositeType
        {
            get { return (INestedInterfaceSyntax)CompositeType; }
        }

        IInterfaceSyntax IHasCompositeType<IInterfaceSyntax>.CompositeType
        {
            get { return (IInterfaceSyntax)CompositeType; }
        }

        ITypeSyntax IHasDeclaringType<ITypeSyntax>.DeclaringType
        {
            get { return (ITypeSyntax)DeclaringType; }
        }

        IDocumentSyntax IHasDocument<IDocumentSyntax>.Document
        {
            get { return (IDocumentSyntax)Document; }
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
            return IsNestedType ?
                (AbstractSyntaxNode)new NestedInterfaceDeclarationWithSyntax(this) :
                new InterfaceDeclarationWithSyntax(this);
        }
    }
}
