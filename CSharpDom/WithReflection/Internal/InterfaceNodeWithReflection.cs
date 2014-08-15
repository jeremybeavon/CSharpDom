using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class InterfaceNodeWithReflection : InterfaceNodeWithSymbols, IInterfaceWithReflection,
        INestedInterfaceWithReflection
    {
        public InterfaceNodeWithReflection(InterfaceDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public IInterfaceWithSymbols Symbols
        {
            get { return this; }
        }

        public Type Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IReadOnlyCollection<INestedInterfaceDeclarationWithReflection> IHasDeclarations<INestedInterfaceDeclarationWithReflection>.Declarations
        {
            get { return new ReadOnlyNodeCollection<INestedInterfaceDeclarationWithReflection, InterfaceDeclarationNode>(Declarations); }
        }

        IReadOnlyCollection<IInterfaceDeclarationWithReflection> IHasDeclarations<IInterfaceDeclarationWithReflection>.Declarations
        {
            get { return new ReadOnlyNodeCollection<IInterfaceDeclarationWithReflection, InterfaceDeclarationNode>(Declarations); }
        }

        ITypeWithReflection IHasDeclaringType<ITypeWithReflection>.DeclaringType
        {
            get { return (ITypeWithReflection)DeclaringType; }
        }

        IReadOnlyCollection<IEventWithReflection> IHasEvents<IEventWithReflection>.Events
        {
            get { return new ReadOnlyNodeCollection<IEventWithReflection, EventNode>(Events); }
        }

        IReadOnlyCollection<IIndexerWithReflection> IHasIndexers<IIndexerWithReflection>.Indexers
        {
            get { return new ReadOnlyNodeCollection<IIndexerWithReflection, IndexerNode>(Indexers); }
        }

        IReadOnlyCollection<IMethodWithReflection> IHasMethods<IMethodWithReflection>.Methods
        {
            get { return new ReadOnlyNodeCollection<IMethodWithReflection, MethodNode>(Methods); }
        }

        INamespaceWithReflection IHasNamespace<INamespaceWithReflection>.Namespace
        {
            get { return (INamespaceWithReflection)Namespace; }
        }

        IProjectWithReflection IHasProject<IProjectWithReflection>.Project
        {
            get { return (IProjectWithReflection)Project; }
        }

        IReadOnlyCollection<IPropertyWithReflection> IHasProperties<IPropertyWithReflection>.Properties
        {
            get { return new ReadOnlyNodeCollection<IPropertyWithReflection, PropertyNode>(Properties); }
        }

        ISolutionWithReflection IHasSolution<ISolutionWithReflection>.Solution
        {
            get { return (ISolutionWithReflection)Solution; }
        }

        INestedInterfaceWithSymbols IHasSymbols<INestedInterfaceWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
